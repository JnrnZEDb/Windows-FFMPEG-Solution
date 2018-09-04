using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

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

        private void onlineUploadTabButton_Click(object sender, EventArgs e)
        {

        }
    }
    internal class UploadVideo
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("YouTube Data API: Upload Video");
            Console.WriteLine("==============================");

            try
            {
                new UploadVideo().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
