namespace ImageCropper {
    partial class frmMain {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.btnDestinationDirectory = new System.Windows.Forms.Button();
            this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
            this.lblDestinationDirectory = new System.Windows.Forms.Label();
            this.numRectWidth = new System.Windows.Forms.NumericUpDown();
            this.numRectHeight = new System.Windows.Forms.NumericUpDown();
            this.lblCropRect = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picProcess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectHeight)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(12, 19);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(87, 13);
            this.lblSourceDirectory.TabIndex = 0;
            this.lblSourceDirectory.Text = "Quellverzeichnis:";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(105, 12);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.ReadOnly = true;
            this.txtSourceDirectory.Size = new System.Drawing.Size(657, 20);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceDirectory.Location = new System.Drawing.Point(768, 12);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(20, 20);
            this.btnSourceDirectory.TabIndex = 2;
            this.btnSourceDirectory.Text = "...";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSourceDirectory.Click += new System.EventHandler(this.btnSourceDirectory_Click);
            // 
            // btnDestinationDirectory
            // 
            this.btnDestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestinationDirectory.Location = new System.Drawing.Point(768, 38);
            this.btnDestinationDirectory.Name = "btnDestinationDirectory";
            this.btnDestinationDirectory.Size = new System.Drawing.Size(20, 20);
            this.btnDestinationDirectory.TabIndex = 5;
            this.btnDestinationDirectory.Text = "...";
            this.btnDestinationDirectory.UseVisualStyleBackColor = true;
            this.btnDestinationDirectory.Click += new System.EventHandler(this.btnDestinationDirectory_Click);
            // 
            // txtDestinationDirectory
            // 
            this.txtDestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationDirectory.Location = new System.Drawing.Point(105, 38);
            this.txtDestinationDirectory.Name = "txtDestinationDirectory";
            this.txtDestinationDirectory.ReadOnly = true;
            this.txtDestinationDirectory.Size = new System.Drawing.Size(657, 20);
            this.txtDestinationDirectory.TabIndex = 4;
            // 
            // lblDestinationDirectory
            // 
            this.lblDestinationDirectory.AutoSize = true;
            this.lblDestinationDirectory.Location = new System.Drawing.Point(19, 45);
            this.lblDestinationDirectory.Name = "lblDestinationDirectory";
            this.lblDestinationDirectory.Size = new System.Drawing.Size(80, 13);
            this.lblDestinationDirectory.TabIndex = 3;
            this.lblDestinationDirectory.Text = "Zielverzeichnis:";
            // 
            // numRectWidth
            // 
            this.numRectWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRectWidth.Location = new System.Drawing.Point(3, 3);
            this.numRectWidth.Name = "numRectWidth";
            this.numRectWidth.Size = new System.Drawing.Size(322, 20);
            this.numRectWidth.TabIndex = 6;
            this.numRectWidth.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // numRectHeight
            // 
            this.numRectHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRectHeight.Location = new System.Drawing.Point(331, 3);
            this.numRectHeight.Name = "numRectHeight";
            this.numRectHeight.Size = new System.Drawing.Size(323, 20);
            this.numRectHeight.TabIndex = 7;
            this.numRectHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblCropRect
            // 
            this.lblCropRect.AutoSize = true;
            this.lblCropRect.Location = new System.Drawing.Point(49, 71);
            this.lblCropRect.Name = "lblCropRect";
            this.lblCropRect.Size = new System.Drawing.Size(50, 13);
            this.lblCropRect.TabIndex = 8;
            this.lblCropRect.Text = "Croprect:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnStart, 2);
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(3, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(651, 22);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numRectWidth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numRectHeight, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(105, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 56);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // picProcess
            // 
            this.picProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProcess.Location = new System.Drawing.Point(12, 126);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(776, 312);
            this.picProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProcess.TabIndex = 11;
            this.picProcess.TabStop = false;
            this.picProcess.Paint += new System.Windows.Forms.PaintEventHandler(this.picProcess_Paint);
            this.picProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picProcess_MouseDown);
            this.picProcess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picProcess_MouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picProcess);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCropRect);
            this.Controls.Add(this.btnDestinationDirectory);
            this.Controls.Add(this.txtDestinationDirectory);
            this.Controls.Add(this.lblDestinationDirectory);
            this.Controls.Add(this.btnSourceDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.lblSourceDirectory);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "ImageCropper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectHeight)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.Button btnDestinationDirectory;
        private System.Windows.Forms.TextBox txtDestinationDirectory;
        private System.Windows.Forms.Label lblDestinationDirectory;
        private System.Windows.Forms.NumericUpDown numRectWidth;
        private System.Windows.Forms.NumericUpDown numRectHeight;
        private System.Windows.Forms.Label lblCropRect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picProcess;
    }
}

