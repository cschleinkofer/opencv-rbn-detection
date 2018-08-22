import argparse
import sys
import datetime
import csv
import os

# -videofile
# /Volumes/DiskName/LaptopExtern/2018-07-21/16-06-47.nut
# -videostart
# 16:06:47.0600
# -resultsfile
# /Users/schleinkofer/Desktop/videoresults.csv
# -outputdirectory
# /Users/schleinkofer/Desktop/test/


def parse_arguments():
    parser = argparse.ArgumentParser()
    parser.add_argument('-videofile')
    parser.add_argument('-videostart')
    parser.add_argument('-resultsfile')
    parser.add_argument('-outputdirectory')
    args = parser.parse_args()
    return args


def process(input_video, input_start, input_results, output_directory):
    # read input start
    input_start_time = datetime.datetime.strptime(input_start, "%H:%M:%S.%f")

    # read input results
    with open(input_results, mode='r', encoding='utf-8-sig') as csvfile:
        spamreader = csv.reader(csvfile, delimiter=';', quotechar='|')
        for row in spamreader:
            input_result_snr = int(row[0])
            input_result_time = datetime.datetime.strptime(row[1], "%H:%M:%S.%f")
            input_video_time = input_result_time - input_start_time
            output_file = output_directory + str(input_result_snr) + ".jpg"
            os.system("ffmpeg -ss " + str(input_video_time) + " -i " + input_video + " -q:v 2 -vframes 1 -f image2 " + output_file)


def main():
    arguments = parse_arguments()

    if arguments.videofile is None:
        print("No video file provided")
        sys.exit(2)

    if arguments.videostart is None:
        print("No video start time provided")
        sys.exit(2)

    if arguments.resultsfile is None:
        print("No finisher file provided")
        sys.exit(2)

    if arguments.outputdirectory is None:
        print("No output directory provided")
        sys.exit(2)

    process(arguments.videofile, arguments.videostart, arguments.resultsfile, arguments.outputdirectory)


if __name__ == "__main__":
    main()
