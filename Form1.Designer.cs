namespace Windows_FFMPEG_Solution
{
    partial class Form1
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
            this.videoUploadButton = new System.Windows.Forms.Button();
            this.video1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // videoUploadButton
            // 
            this.videoUploadButton.Location = new System.Drawing.Point(707, 202);
            this.videoUploadButton.Name = "videoUploadButton";
            this.videoUploadButton.Size = new System.Drawing.Size(345, 92);
            this.videoUploadButton.TabIndex = 0;
            this.videoUploadButton.Text = "Upload a Video";
            this.videoUploadButton.UseVisualStyleBackColor = true;
            this.videoUploadButton.Click += new System.EventHandler(this.videoUploadButton_Click);
            // 
            // video1TextBox
            // 
            this.video1TextBox.Location = new System.Drawing.Point(53, 224);
            this.video1TextBox.Multiline = true;
            this.video1TextBox.Name = "video1TextBox";
            this.video1TextBox.Size = new System.Drawing.Size(536, 70);
            this.video1TextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 622);
            this.Controls.Add(this.video1TextBox);
            this.Controls.Add(this.videoUploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button videoUploadButton;
        private System.Windows.Forms.TextBox video1TextBox;
    }
}

