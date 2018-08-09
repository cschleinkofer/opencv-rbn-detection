using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageCropper {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private int mSourceFileIndex = -1;
        private FileInfo[] mSourceFiles;
        private DirectoryInfo mDestinationDirectory;
        private Point mStartPoint;
        private readonly Pen mPen = new Pen(Color.Red, 3.0f);

        private void btnSourceDirectory_Click(object sender, EventArgs e) {
            try {
                using (var fbd = new FolderBrowserDialog()) {
                    if (fbd.ShowDialog() == DialogResult.OK) {
                        txtSourceDirectory.Text = fbd.SelectedPath;
                        mSourceFiles = new DirectoryInfo(fbd.SelectedPath).GetFiles("*.jpg");
                        UpdateButtons();
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void btnDestinationDirectory_Click(object sender, EventArgs e) {
            try {
                using (var fbd = new FolderBrowserDialog()) {
                    if (fbd.ShowDialog() == DialogResult.OK) {
                        txtDestinationDirectory.Text = fbd.SelectedPath;
                        mDestinationDirectory = new DirectoryInfo(fbd.SelectedPath);
                        UpdateButtons();
                    }
                }
            } catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void UpdateButtons() {
            btnStart.Enabled = mSourceFiles != null && mDestinationDirectory != null;
        }

        private void LoadImage() {
            if (mSourceFileIndex >= mSourceFiles.Length) {
                mSourceFileIndex = 0;
            }

            var file = mSourceFiles[mSourceFileIndex];
            Text = file.Name;

            using (var stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Write)) {
                picProcess.Image = new Bitmap(stream);
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e) {
            try {
                mSourceFileIndex = 0;

                //Process first image
                LoadImage();
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if (mSourceFileIndex < 0) {
                return;
            }

            switch (e.KeyCode) {
                case Keys.Left:
                    if (mSourceFileIndex > 0) {
                        mSourceFileIndex--;
                        LoadImage();
                    }
                    break;
                case Keys.Right:
                    if (mSourceFileIndex < mSourceFiles.Length - 1) {
                        mSourceFileIndex++;
                        LoadImage();
                    }
                    break;
                case Keys.Space:
                    break;
            }
        }

        

        public Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight) {
            var rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            var bmp = new Bitmap(rect.Width, rect.Height);
            using (var gph = Graphics.FromImage(bmp)) {
                gph.DrawImage(bitmap, new Rectangle(0, 0, bmp.Width, bmp.Height), rect, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        private void picProcess_MouseDown(object sender, MouseEventArgs e) {
            if (null == picProcess.Image) {
                return;
            }

            //Save image
            var result = picProcess.CropImage(mStartPoint.X, mStartPoint.Y, (int)numRectWidth.Value, (int)numRectHeight.Value);
            result.Save(Path.Combine(txtDestinationDirectory.Text, mSourceFileIndex + ".jpg"));
            if (mSourceFileIndex < mSourceFiles.Length - 1) {
                mSourceFileIndex++;
                LoadImage();
            }

           
        }

        private void picProcess_MouseMove(object sender, MouseEventArgs e) {
            mStartPoint = e.Location;
            picProcess.Invalidate();
        }

        private void picProcess_Paint(object sender, PaintEventArgs e) {
            if (null == picProcess.Image) {
                return;
            }

            e.Graphics.DrawRectangle(mPen, mStartPoint.X, mStartPoint.Y, (int)numRectWidth.Value, (int)numRectHeight.Value);
        }
    }
}
