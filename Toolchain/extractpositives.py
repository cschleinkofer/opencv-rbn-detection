import argparse
import sys
import time
import subprocess


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
    struct_time = time.strptime(input_start, "%H:%M:%S")
    print("returned tuple: %s " % struct_time)

    # read input results

    # execute command

    print(input_video)
    print(input_start)
    print(input_results)
    print(output_directory)


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
