import cv2 
import argparse
import sys
import glob

def get_args():
	parser = argparse.ArgumentParser()
	parser.add_argument('-i', dest='input_directory')
	parser.add_argument('-o', dest='output_directory')
	args = parser.parse_args()
	return (args.input_directory, args.output_directory)

def process_files(input_directory, output_directory):
    if input_directory.endsWith('/'):
        input_directory = input_directory[:-1]
    
    if output_directory.endsWith('/'):
        output_directory = output_directory[:-1]

    input_files = glob.glob('{0}/*.jpg'.format(input_directory))

    if len(files) <= 0:
        print('No input files found')
        sys.exit(1)

    for input_file in input_files:
        

if __name__ == '__main__':
    input_directory, output_directory = get_args()
    if not input_directory:
        sys.exit('imageclipper requires a directory of input files')
    if not output_directory:
        sys.exit('imageclipper requires a output directory')

    process_files(input_directory, output_directory)