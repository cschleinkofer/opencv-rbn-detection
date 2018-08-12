import cv2
import argparse
import os


def parse_arguments():
    parser = argparse.ArgumentParser()
    parser.add_argument('-id')
    parser.add_argument('-od')
    args = parser.parse_args()
    return args


def get_files(path):
    for root, dirs, files in os.walk(path):
        for filename in files:
            yield os.path.join(root, filename)


def main():
    arguments = parse_arguments()

    if arguments.id is None:
        print("No input directory provided")
        exit(0)

    if arguments.od is None:
        print("No output directory provided")
        exit(0)

    process(arguments.id, arguments.od)


def process(input_directory, output_directory):
    files = get_files(input_directory)
    for file in files:
        print(file)


if __name__ == "__main__":
    main()


