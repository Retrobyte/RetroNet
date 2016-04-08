namespace RetroNet.Forms
{
    partial class RemoteDesktopDialog
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
            this.keyboardCheckBox = new System.Windows.Forms.CheckBox();
            this.mouseCheckBox = new System.Windows.Forms.CheckBox();
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.desktopPictureBox = new System.Windows.Forms.PictureBox();
            this.mousePictureBox = new System.Windows.Forms.PictureBox();
            this.keyboardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mousePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // keyboardCheckBox
            // 
            this.keyboardCheckBox.AutoSize = true;
            this.keyboardCheckBox.Location = new System.Drawing.Point(35, 12);
            this.keyboardCheckBox.Name = "keyboardCheckBox";
            this.keyboardCheckBox.Size = new System.Drawing.Size(74, 17);
            this.keyboardCheckBox.TabIndex = 1;
            this.keyboardCheckBox.Text = "Keyboard";
            this.keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // mouseCheckBox
            // 
            this.mouseCheckBox.AutoSize = true;
            this.mouseCheckBox.Location = new System.Drawing.Point(138, 12);
            this.mouseCheckBox.Name = "mouseCheckBox";
            this.mouseCheckBox.Size = new System.Drawing.Size(61, 17);
            this.mouseCheckBox.TabIndex = 3;
            this.mouseCheckBox.Text = "Mouse";
            this.mouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityTrackBar.AutoSize = false;
            this.qualityTrackBar.Location = new System.Drawing.Point(205, 9);
            this.qualityTrackBar.Maximum = 50;
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.Size = new System.Drawing.Size(252, 20);
            this.qualityTrackBar.TabIndex = 4;
            this.qualityTrackBar.Value = 50;
            this.qualityTrackBar.Scroll += new System.EventHandler(this.qualityTrackBar_Scroll);
            // 
            // desktopPictureBox
            // 
            this.desktopPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopPictureBox.Location = new System.Drawing.Point(0, 35);
            this.desktopPictureBox.Name = "desktopPictureBox";
            this.desktopPictureBox.Size = new System.Drawing.Size(469, 264);
            this.desktopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.desktopPictureBox.TabIndex = 5;
            this.desktopPictureBox.TabStop = false;
            this.desktopPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.desktopPictureBox_MouseDown);
            this.desktopPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.desktopPictureBox_MouseUp);
            // 
            // mousePictureBox
            // 
            this.mousePictureBox.Image = global::RetroNet.Properties.Resources.mouse;
            this.mousePictureBox.Location = new System.Drawing.Point(115, 12);
            this.mousePictureBox.Name = "mousePictureBox";
            this.mousePictureBox.Size = new System.Drawing.Size(17, 17);
            this.mousePictureBox.TabIndex = 2;
            this.mousePictureBox.TabStop = false;
            // 
            // keyboardPictureBox
            // 
            this.keyboardPictureBox.Image = global::RetroNet.Properties.Resources.keyboard;
            this.keyboardPictureBox.Location = new System.Drawing.Point(12, 12);
            this.keyboardPictureBox.Name = "keyboardPictureBox";
            this.keyboardPictureBox.Size = new System.Drawing.Size(17, 17);
            this.keyboardPictureBox.TabIndex = 0;
            this.keyboardPictureBox.TabStop = false;
            // 
            // RemoteDesktopDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 299);
            this.Controls.Add(this.desktopPictureBox);
            this.Controls.Add(this.qualityTrackBar);
            this.Controls.Add(this.mouseCheckBox);
            this.Controls.Add(this.mousePictureBox);
            this.Controls.Add(this.keyboardCheckBox);
            this.Controls.Add(this.keyboardPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteDesktopDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteDesktopDialog_FormClosing);
            this.Load += new System.EventHandler(this.RemoteDesktopDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteDesktopDialog_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemoteDesktopDialog_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mousePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox keyboardPictureBox;
        private System.Windows.Forms.CheckBox keyboardCheckBox;
        private System.Windows.Forms.PictureBox mousePictureBox;
        private System.Windows.Forms.CheckBox mouseCheckBox;
        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.PictureBox desktopPictureBox;
    }
}