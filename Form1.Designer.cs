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
            this.classicCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.allTab = new System.Windows.Forms.TabControl();
            this.mediagenTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.uploadTab = new System.Windows.Forms.TabPage();
            this.testlabel = new System.Windows.Forms.Label();
            this.tagsUploadTabTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descriptionUploadTabTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labe8 = new System.Windows.Forms.Label();
            this.titleUploadTabTextBox = new System.Windows.Forms.TextBox();
            this.onlineUploadTabButton = new System.Windows.Forms.Button();
            this.thumbnailUploadTabTextBox = new System.Windows.Forms.TextBox();
            this.thumbnailUploadTabButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.progresslabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.videoUploadTabTextBox = new System.Windows.Forms.TextBox();
            this.videoUploadTabButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.testbutton = new System.Windows.Forms.Button();
            this.allTab.SuspendLayout();
            this.mediagenTab.SuspendLayout();
            this.uploadTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // classicCheckBox
            // 
            this.classicCheckBox.AutoSize = true;
            this.classicCheckBox.Location = new System.Drawing.Point(53, 61);
            this.classicCheckBox.Name = "classicCheckBox";
            this.classicCheckBox.Size = new System.Drawing.Size(319, 29);
            this.classicCheckBox.TabIndex = 5;
            this.classicCheckBox.Text = "Check for Classic Intro/Outro";
            this.classicCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 37);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "C:\\\\VIDEO PATH";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(694, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Upload a Video";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 170);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(536, 37);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "C:\\\\VIDEO PATH";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(694, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Upload a Video";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.mediagenTab);
            this.allTab.Controls.Add(this.uploadTab);
            this.allTab.Location = new System.Drawing.Point(0, 0);
            this.allTab.Name = "allTab";
            this.allTab.SelectedIndex = 0;
            this.allTab.Size = new System.Drawing.Size(1751, 906);
            this.allTab.TabIndex = 15;
            // 
            // mediagenTab
            // 
            this.mediagenTab.BackColor = System.Drawing.Color.Gainsboro;
            this.mediagenTab.Controls.Add(this.label1);
            this.mediagenTab.Controls.Add(this.label2);
            this.mediagenTab.Controls.Add(this.textBox3);
            this.mediagenTab.Controls.Add(this.label3);
            this.mediagenTab.Controls.Add(this.textBox4);
            this.mediagenTab.Controls.Add(this.label4);
            this.mediagenTab.Controls.Add(this.label5);
            this.mediagenTab.Controls.Add(this.progressBar2);
            this.mediagenTab.Location = new System.Drawing.Point(8, 39);
            this.mediagenTab.Name = "mediagenTab";
            this.mediagenTab.Padding = new System.Windows.Forms.Padding(3);
            this.mediagenTab.Size = new System.Drawing.Size(1735, 859);
            this.mediagenTab.TabIndex = 0;
            this.mediagenTab.Text = "MediaGen";
            this.mediagenTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 31);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Length:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 31);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1061, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Not Started";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label5.Location = new System.Drawing.Point(-3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Progress";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(192, 212);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(839, 57);
            this.progressBar2.TabIndex = 11;
            // 
            // uploadTab
            // 
            this.uploadTab.BackColor = System.Drawing.Color.LightGray;
            this.uploadTab.Controls.Add(this.testbutton);
            this.uploadTab.Controls.Add(this.dateTimePicker2);
            this.uploadTab.Controls.Add(this.testlabel);
            this.uploadTab.Controls.Add(this.tagsUploadTabTextBox);
            this.uploadTab.Controls.Add(this.label8);
            this.uploadTab.Controls.Add(this.descriptionUploadTabTextBox);
            this.uploadTab.Controls.Add(this.label9);
            this.uploadTab.Controls.Add(this.labe8);
            this.uploadTab.Controls.Add(this.titleUploadTabTextBox);
            this.uploadTab.Controls.Add(this.onlineUploadTabButton);
            this.uploadTab.Controls.Add(this.thumbnailUploadTabTextBox);
            this.uploadTab.Controls.Add(this.thumbnailUploadTabButton);
            this.uploadTab.Controls.Add(this.dateTimePicker1);
            this.uploadTab.Controls.Add(this.checkedListBox1);
            this.uploadTab.Controls.Add(this.progresslabel);
            this.uploadTab.Controls.Add(this.label7);
            this.uploadTab.Controls.Add(this.progressBar3);
            this.uploadTab.Controls.Add(this.videoUploadTabTextBox);
            this.uploadTab.Controls.Add(this.videoUploadTabButton);
            this.uploadTab.Location = new System.Drawing.Point(8, 39);
            this.uploadTab.Name = "uploadTab";
            this.uploadTab.Padding = new System.Windows.Forms.Padding(3);
            this.uploadTab.Size = new System.Drawing.Size(1735, 859);
            this.uploadTab.TabIndex = 1;
            this.uploadTab.Text = "Upload";
            this.uploadTab.Click += new System.EventHandler(this.uploadTab_Click);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(944, 75);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(70, 25);
            this.testlabel.TabIndex = 23;
            this.testlabel.Text = "label6";
            // 
            // tagsUploadTabTextBox
            // 
            this.tagsUploadTabTextBox.Location = new System.Drawing.Point(261, 456);
            this.tagsUploadTabTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.tagsUploadTabTextBox.Multiline = true;
            this.tagsUploadTabTextBox.Name = "tagsUploadTabTextBox";
            this.tagsUploadTabTextBox.Size = new System.Drawing.Size(1036, 62);
            this.tagsUploadTabTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tags:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // descriptionUploadTabTextBox
            // 
            this.descriptionUploadTabTextBox.Location = new System.Drawing.Point(263, 374);
            this.descriptionUploadTabTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionUploadTabTextBox.Multiline = true;
            this.descriptionUploadTabTextBox.Name = "descriptionUploadTabTextBox";
            this.descriptionUploadTabTextBox.Size = new System.Drawing.Size(1036, 62);
            this.descriptionUploadTabTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 393);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Video description:";
            // 
            // labe8
            // 
            this.labe8.AutoSize = true;
            this.labe8.Location = new System.Drawing.Point(154, 315);
            this.labe8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labe8.Name = "labe8";
            this.labe8.Size = new System.Drawing.Size(59, 25);
            this.labe8.TabIndex = 18;
            this.labe8.Text = "Title:";
            // 
            // titleUploadTabTextBox
            // 
            this.titleUploadTabTextBox.Location = new System.Drawing.Point(261, 312);
            this.titleUploadTabTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.titleUploadTabTextBox.Name = "titleUploadTabTextBox";
            this.titleUploadTabTextBox.Size = new System.Drawing.Size(1036, 31);
            this.titleUploadTabTextBox.TabIndex = 17;
            // 
            // onlineUploadTabButton
            // 
            this.onlineUploadTabButton.Location = new System.Drawing.Point(1301, 638);
            this.onlineUploadTabButton.Name = "onlineUploadTabButton";
            this.onlineUploadTabButton.Size = new System.Drawing.Size(354, 83);
            this.onlineUploadTabButton.TabIndex = 14;
            this.onlineUploadTabButton.Text = "Upload Online";
            this.onlineUploadTabButton.UseVisualStyleBackColor = true;
            this.onlineUploadTabButton.Click += new System.EventHandler(this.onlineUploadTabButton_Click);
            // 
            // thumbnailUploadTabTextBox
            // 
            this.thumbnailUploadTabTextBox.Location = new System.Drawing.Point(72, 212);
            this.thumbnailUploadTabTextBox.Name = "thumbnailUploadTabTextBox";
            this.thumbnailUploadTabTextBox.Size = new System.Drawing.Size(697, 31);
            this.thumbnailUploadTabTextBox.TabIndex = 13;
            this.thumbnailUploadTabTextBox.Text = "C:\\\\IMAGE PATH";
            // 
            // thumbnailUploadTabButton
            // 
            this.thumbnailUploadTabButton.AutoSize = true;
            this.thumbnailUploadTabButton.Location = new System.Drawing.Point(883, 202);
            this.thumbnailUploadTabButton.Name = "thumbnailUploadTabButton";
            this.thumbnailUploadTabButton.Size = new System.Drawing.Size(345, 50);
            this.thumbnailUploadTabButton.TabIndex = 12;
            this.thumbnailUploadTabButton.Text = "Upload a Thumbnail";
            this.thumbnailUploadTabButton.UseVisualStyleBackColor = true;
            this.thumbnailUploadTabButton.Click += new System.EventHandler(this.thumbnailUploadTabButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 587);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 9, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(394, 31);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 8, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Facebook",
            "Youtube",
            "Twitter"});
            this.checkedListBox1.Location = new System.Drawing.Point(72, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(230, 82);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Location = new System.Drawing.Point(1108, 781);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(120, 25);
            this.progresslabel.TabIndex = 9;
            this.progresslabel.Text = "Not Started";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label7.Location = new System.Drawing.Point(43, 767);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Progress";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(238, 758);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(839, 57);
            this.progressBar3.TabIndex = 7;
            // 
            // videoUploadTabTextBox
            // 
            this.videoUploadTabTextBox.Location = new System.Drawing.Point(72, 136);
            this.videoUploadTabTextBox.Name = "videoUploadTabTextBox";
            this.videoUploadTabTextBox.Size = new System.Drawing.Size(697, 31);
            this.videoUploadTabTextBox.TabIndex = 6;
            this.videoUploadTabTextBox.Text = "C:\\\\VIDEO PATH";
            // 
            // videoUploadTabButton
            // 
            this.videoUploadTabButton.AutoSize = true;
            this.videoUploadTabButton.Location = new System.Drawing.Point(883, 126);
            this.videoUploadTabButton.Name = "videoUploadTabButton";
            this.videoUploadTabButton.Size = new System.Drawing.Size(345, 50);
            this.videoUploadTabButton.TabIndex = 5;
            this.videoUploadTabButton.Text = "Upload a Video";
            this.videoUploadTabButton.UseVisualStyleBackColor = true;
            this.videoUploadTabButton.Click += new System.EventHandler(this.videoUploadTabButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(478, 587);
            this.dateTimePicker2.MinDate = new System.DateTime(2018, 9, 8, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.Value = new System.DateTime(2018, 9, 8, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(867, 17);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(252, 42);
            this.testbutton.TabIndex = 25;
            this.testbutton.Text = "TEST";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1735, 893);
            this.Controls.Add(this.allTab);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classicCheckBox);
            this.Name = "Form1";
            this.Text = "Parable Generator";
            this.allTab.ResumeLayout(false);
            this.mediagenTab.ResumeLayout(false);
            this.mediagenTab.PerformLayout();
            this.uploadTab.ResumeLayout(false);
            this.uploadTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox classicCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl allTab;
        private System.Windows.Forms.TabPage mediagenTab;
        private System.Windows.Forms.TabPage uploadTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox videoUploadTabTextBox;
        private System.Windows.Forms.Button videoUploadTabButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox thumbnailUploadTabTextBox;
        private System.Windows.Forms.Button thumbnailUploadTabButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button onlineUploadTabButton;
        private System.Windows.Forms.TextBox tagsUploadTabTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descriptionUploadTabTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labe8;
        private System.Windows.Forms.TextBox titleUploadTabTextBox;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button testbutton;
    }
}

