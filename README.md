# OpenCV RBN Detection

# Install OpenCV

https://coding-robin.de/2013/07/22/train-your-own-opencv-haar-classifier.html

opencv_traincascade -data classifier -vec samples.vec -bg negatives.txt\
  -numStages 20 -minHitRate 0.999 -maxFalseAlarmRate 0.5 -numPos 44\
  -numNeg 714 -w 52 -h 40 -mode ALL -precalcValBufSize 1024\
  -precalcIdxBufSize 1024

