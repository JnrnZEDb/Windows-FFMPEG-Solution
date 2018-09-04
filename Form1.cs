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

        private void videoUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openvideo1FileDialog = new OpenFileDialog();
            openvideo1FileDialog.Filter = "Choose a video file|*.mp4";
            openvideo1FileDialog.Title = "Select a Cursor File";
            if (openvideo1FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                video1TextBox.Text = openvideo1FileDialog.InitialDirectory + openvideo1FileDialog.FileName; ;
            }
        }
    }
}
