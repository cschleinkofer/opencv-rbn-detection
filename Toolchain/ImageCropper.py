import cv2
import argparse
import os
import sys

current_image = None
crop_rect_left = 0
crop_rect_top = 0
crop_rect_width = 0.0
crop_rect_height = 0.0
crop_rect_ratio = 0.0


def parse_arguments():
    parser = argparse.ArgumentParser()
    parser.add_argument('-id')
    parser.add_argument('-od')
    parser.add_argument('-rw')
    parser.add_argument('-rh')
    args = parser.parse_args()
    return args


def get_files(path):
    for root, dirs, files in os.walk(path):
        for filename in files:
            yield os.path.join(root, filename)


def main():
    global crop_rect_width, crop_rect_height, crop_rect_ratio

    arguments = parse_arguments()

    if arguments.id is None:
        print("No input directory provided")
        sys.exit(2)

    if arguments.od is None:
        print("No output directory provided")
        sys.exit(2)

    if arguments.rw is None:
        print("No crop rect width specified")
        sys.exit(2)

    if arguments.rh is None:
        print("No crop rect height specified")
        sys.exit(2)

    crop_rect_width = float(arguments.rw)
    crop_rect_height = float(arguments.rh)
    crop_rect_ratio = crop_rect_width / crop_rect_height
    process(arguments.id, arguments.od)


def callback(event, x, y, flags, param):
    global current_image, crop_rect_left, crop_rect_top

    if current_image is None:
        return

    if crop_rect_width == 0:
        return

    if crop_rect_height == 0:
        return

    crop_rect_left = x
    crop_rect_top = y

    clone = current_image.copy()

    cv2.rectangle(clone, (int(x), int(y)), (int(x + crop_rect_width), int(y + crop_rect_height)), (0, 255, 0), 3)
    cv2.imshow('ImageWindow', clone)

    crop_img = clone[int(y):int(y + crop_rect_height), int(x):int(x + crop_rect_width)]
    cv2.imshow('PreviewWindow', crop_img)


def crop_current_image(image, x, y, width, height, filename):
    x2 = x + width
    y2 = y + height
    crop_img = image[int(y):int(y2), int(x):int(x2)]
    cv2.imwrite(filename, crop_img)


def process_file(file):
    global current_image
    current_image = cv2.imread(file)
    cv2.imshow('ImageWindow', current_image)

    return cv2.waitKey(0) & 0xFF


def process(input_directory, output_directory):
    global crop_rect_width, crop_rect_height, crop_rect_ratio

    cv2.namedWindow('ImageWindow', cv2.WINDOW_NORMAL)
    cv2.resizeWindow('ImageWindow', 1024, 768)
    cv2.namedWindow('PreviewWindow', cv2.WINDOW_AUTOSIZE)
    cv2.setMouseCallback('ImageWindow', callback)

    input_files = list(get_files(input_directory))
    list_index = 0

    while list_index < len(input_files):
        if list_index < 0:
            list_index = 0

        input_file = input_files[list_index]
        output_file = os.path.join(output_directory, os.path.basename(input_file))
        pressed_key = process_file(input_file)

        if pressed_key == ord('q'):
            break
        elif pressed_key == ord('+'):
            crop_rect_width += 5
            crop_rect_height = crop_rect_width / crop_rect_ratio
            continue
        elif pressed_key == ord('-'):
            if crop_rect_width > 10:
                crop_rect_width -= 5
                crop_rect_height = crop_rect_width / crop_rect_ratio
        elif pressed_key == ord('s'):
            crop_current_image(current_image, crop_rect_left, crop_rect_top, crop_rect_width, crop_rect_height,
                               output_file)
            continue
        elif pressed_key == ord('p'):
            list_index -= 1
            continue
        elif pressed_key == ord('n'):
            list_index += 1
            continue
        elif pressed_key == 32:
            crop_current_image(current_image, crop_rect_left, crop_rect_top, crop_rect_width, crop_rect_height,
                               output_file)
            list_index += 1
            continue

    cv2.destroyAllWindows()


if __name__ == "__main__":
    main()
