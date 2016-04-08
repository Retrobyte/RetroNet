namespace RetroNet.Forms
{
    partial class WebcamDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.webcamPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityTrackBar.AutoSize = false;
            this.qualityTrackBar.Location = new System.Drawing.Point(12, 9);
            this.qualityTrackBar.Maximum = 50;
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.Size = new System.Drawing.Size(445, 20);
            this.qualityTrackBar.TabIndex = 0;
            this.qualityTrackBar.Value = 50;
            this.qualityTrackBar.Scroll += new System.EventHandler(this.qualityTrackBar_Scroll);
            // 
            // webcamPictureBox
            // 
            this.webcamPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webcamPictureBox.Location = new System.Drawing.Point(0, 35);
            this.webcamPictureBox.Name = "webcamPictureBox";
            this.webcamPictureBox.Size = new System.Drawing.Size(469, 264);
            this.webcamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.webcamPictureBox.TabIndex = 1;
            this.webcamPictureBox.TabStop = false;
            // 
            // WebcamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 299);
            this.Controls.Add(this.webcamPictureBox);
            this.Controls.Add(this.qualityTrackBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebcamDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebcamDialog_FormClosing);
            this.Load += new System.EventHandler(this.WebcamDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.PictureBox webcamPictureBox;
    }
}