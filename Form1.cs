using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
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
            Control.CheckForIllegalCrossThreadCalls = false;
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

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void onlineUploadTabButton_Click(object sender, EventArgs e)
        {
            if (videoUploadTabTextBox.Text.Contains("PATH") || (thumbnailUploadTabTextBox.Text.Contains("PATH")))
            {
                MessageBox.Show("Please select an video/thumbnail first!");
            }
            else
            {
                progresslabel.Text = "Upload started";
                try
                {
                    Thread thead = new Thread(() => {Run().Wait();})
                    {
                        IsBackground = true
                    };
                    thead.Start();

                }
                catch (AggregateException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            async Task Run()
            {
                UserCredential credential;
                using (var stream = new FileStream("/Windows/JSON/client_id.json", FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        // This OAuth 2.0 access scope allows an application to upload files to the
                        // authenticated user's YouTube channel, but doesn't allow other types of access.
                        new[] { YouTubeService.Scope.YoutubeUpload },
                        "user",
                        CancellationToken.None
                    );
                }

                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
                });

                var video = new Video();
                video.Snippet = new VideoSnippet();
                video.Snippet.Title = titleUploadTabTextBox.Text;
                video.Snippet.Description = descriptionUploadTabTextBox.Text;
                string[] puretags = Regex.Split(tagsUploadTabTextBox.Text, ",");
                video.Snippet.Tags = puretags;
                video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
                video.Status = new VideoStatus();
                video.Status.PrivacyStatus = "private"; // or "private" or "public"
                string stringdate = dateTimePicker1.Value.ToString("yyyy:MM:dd") + "T" + dateTimePicker2.Value.ToString("HH:mm") + "Z";
                var truedate = DateTime.ParseExact(stringdate, "yyyy':'MM':'dd'T'HH':'mm'Z'", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None);
                video.Status.PublishAt = truedate;
                var filePath = videoUploadTabTextBox.Text; // Replace with path to actual movie file.

                using (var fileStream = new FileStream(filePath, FileMode.Open))
                {
                    var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                    videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                    videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                    await videosInsertRequest.UploadAsync();
                }
            }
            void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
            {
                switch (progress.Status)
                {
                    case UploadStatus.Uploading:
                        progresslabel.Text = String.Format("{0} bytes sent.", progress.BytesSent);
                        break;

                    case UploadStatus.Failed:
                        progresslabel.Text = String.Format("An error prevented the upload from completing.\n{0}", progress.Exception);
                        break;
                }
                progressBar.Value = 50;
            }
        }
        void videosInsertRequest_ResponseReceived(Video video)
        {
            progresslabel.Text = string.Format("Video id '{0}' was successfully uploaded.", video.Id);
            progressBar.Value = 100;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
        }

        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker2 = new DateTimePicker();
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        public void testbutton_Click(object sender, EventArgs e)
        {
            if (checkedListBox.GetItemChecked(1) == true)
                testlabel.Text = "Selected 1";
                //MessageBox.Show("Please select an Item first!");
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
 
}
