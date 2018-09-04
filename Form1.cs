using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            openvideoUploadTabFileDialog.Filter = "Choose a video file|*.mp4";
            openvideoUploadTabFileDialog.Title = "Select a Cursor File";
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
    }
}
