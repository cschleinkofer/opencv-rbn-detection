# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.12

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/local/Cellar/cmake/3.12.0/bin/cmake

# The command to remove a file.
RM = /usr/local/Cellar/cmake/3.12.0/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build

# Include any dependencies generated for this target.
include CMakeFiles/imageclipper.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/imageclipper.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/imageclipper.dir/flags.make

CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o: CMakeFiles/imageclipper.dir/flags.make
CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o: ../src/imageclipper.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o"
	/Library/Developer/CommandLineTools/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o -c /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/src/imageclipper.cpp

CMakeFiles/imageclipper.dir/src/imageclipper.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/imageclipper.dir/src/imageclipper.cpp.i"
	/Library/Developer/CommandLineTools/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/src/imageclipper.cpp > CMakeFiles/imageclipper.dir/src/imageclipper.cpp.i

CMakeFiles/imageclipper.dir/src/imageclipper.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/imageclipper.dir/src/imageclipper.cpp.s"
	/Library/Developer/CommandLineTools/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/src/imageclipper.cpp -o CMakeFiles/imageclipper.dir/src/imageclipper.cpp.s

# Object files for target imageclipper
imageclipper_OBJECTS = \
"CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o"

# External object files for target imageclipper
imageclipper_EXTERNAL_OBJECTS =

bin/imageclipper: CMakeFiles/imageclipper.dir/src/imageclipper.cpp.o
bin/imageclipper: CMakeFiles/imageclipper.dir/build.make
bin/imageclipper: /usr/local/lib/libopencv_stitching.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_superres.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_videostab.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_aruco.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_bgsegm.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_bioinspired.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_ccalib.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_dnn_objdetect.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_dpm.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_face.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_fuzzy.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_hfs.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_img_hash.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_line_descriptor.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_optflow.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_reg.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_rgbd.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_saliency.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_stereo.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_structured_light.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_surface_matching.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_tracking.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_xfeatures2d.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_ximgproc.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_xobjdetect.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_xphoto.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libboost_system-mt.dylib
bin/imageclipper: /usr/local/lib/libboost_filesystem-mt.dylib
bin/imageclipper: /usr/local/lib/libopencv_shape.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_photo.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_calib3d.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_features2d.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_highgui.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_videoio.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_phase_unwrapping.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_dnn.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_video.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_datasets.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_flann.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_ml.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_plot.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_imgcodecs.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_objdetect.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_imgproc.3.4.2.dylib
bin/imageclipper: /usr/local/lib/libopencv_core.3.4.2.dylib
bin/imageclipper: CMakeFiles/imageclipper.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable bin/imageclipper"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/imageclipper.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/imageclipper.dir/build: bin/imageclipper

.PHONY : CMakeFiles/imageclipper.dir/build

CMakeFiles/imageclipper.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/imageclipper.dir/cmake_clean.cmake
.PHONY : CMakeFiles/imageclipper.dir/clean

CMakeFiles/imageclipper.dir/depend:
	cd /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build /Users/schleinkofer/Documents/Projekte/OpenCV/Toolchain/imageclipper/build/CMakeFiles/imageclipper.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/imageclipper.dir/depend

