using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using Youtube.Classes;

namespace Windows_FFMPEG_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void videoUploadTabButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openvideoUploadTabFileDialog = new OpenFileDialog();
            openvideoUploadTabFileDialog.Filter = "Choose a video file|*.mp4;*.avi;*.wmv;*.mov;*.webm";
            openvideoUploadTabFileDialog.Title = "Choose a video file";
            if (openvideoUploadTabFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                videoUploadTabTextBox.Text = openvideoUploadTabFileDialog.FileName ;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uploadTab_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void onlineUploadTabButton_Click(object sender, EventArgs e)
        {
            UploadVideo openvideo = new UploadVideo();
        }

        private void thumbnailUploadTabButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openthumbnailUploadTabFileDialog = new OpenFileDialog();
            openthumbnailUploadTabFileDialog.Filter = "Choose an image file|*.jpg;*.png;*.jpeg";
            openthumbnailUploadTabFileDialog.Title = "Choose an image file";
            if (openthumbnailUploadTabFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                thumbnailUploadTabTextBox.Text = openthumbnailUploadTabFileDialog.FileName;
            }
        }
    }
 
}
