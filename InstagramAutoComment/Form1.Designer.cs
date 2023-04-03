namespace InstagramAutoComment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.timerefreshGrab = new System.Windows.Forms.Timer(this.components);
            this.timerFunctionGrab = new System.Windows.Forms.Timer(this.components);
            this.TimeCommenting = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClickToPostBtn = new System.Windows.Forms.Timer(this.components);
            this.geckoWebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ClickToCommentBtn = new System.Windows.Forms.Timer(this.components);
            this.FillComment = new System.Windows.Forms.Timer(this.components);
            this.lblURlCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScrollToGrab = new System.Windows.Forms.Timer(this.components);
            this.txtCommentText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCommentTexts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTolist = new System.Windows.Forms.Button();
            this.btntxtLoad = new System.Windows.Forms.Button();
            this.btntxtSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richReport = new System.Windows.Forms.RichTextBox();
            this.lblNumberItemSent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopSpamm = new System.Windows.Forms.Button();
            this.btnStartSpam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imageEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTimeGap = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ckbGrabAll = new System.Windows.Forms.CheckBox();
            this.cknGrabHash = new System.Windows.Forms.CheckBox();
            this.txtHashTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHashTagStart = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(11, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "ورود به اینستاگرام";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timerefreshGrab
            // 
            this.timerefreshGrab.Interval = 15000;
            this.timerefreshGrab.Tick += new System.EventHandler(this.timerefreshGrab_Tick);
            // 
            // timerFunctionGrab
            // 
            this.timerFunctionGrab.Interval = 2000;
            this.timerFunctionGrab.Tick += new System.EventHandler(this.timerFunctionGrab_Tick);
            // 
            // TimeCommenting
            // 
            this.TimeCommenting.Interval = 60000;
            this.TimeCommenting.Tick += new System.EventHandler(this.TimeCommenting_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(913, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(119, 245);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مرحله 1 - احراز هویت";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::InstagramAutoComment.Properties.Resources.b4a49d4b864c74bb73de63f080ad7930_instagram_profile_button;
            this.pictureBox1.Location = new System.Drawing.Point(8, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ClickToPostBtn
            // 
            this.ClickToPostBtn.Interval = 2000;
            this.ClickToPostBtn.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.Location = new System.Drawing.Point(168, 5);
            this.geckoWebBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geckoWebBrowser1.MinimumSize = new System.Drawing.Size(20, 15);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.ScriptErrorsSuppressed = true;
            this.geckoWebBrowser1.Size = new System.Drawing.Size(740, 243);
            this.geckoWebBrowser1.TabIndex = 18;
            this.geckoWebBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.geckoWebBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.geckoWebBrowser1_ProgressChanged);
            // 
            // ClickToCommentBtn
            // 
            this.ClickToCommentBtn.Interval = 3000;
            this.ClickToCommentBtn.Tick += new System.EventHandler(this.ClickToCommentBtn_Tick);
            // 
            // FillComment
            // 
            this.FillComment.Interval = 2000;
            this.FillComment.Tick += new System.EventHandler(this.FillComment_Tick);
            // 
            // lblURlCount
            // 
            this.lblURlCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblURlCount.AutoSize = true;
            this.lblURlCount.Location = new System.Drawing.Point(16, 102);
            this.lblURlCount.Name = "lblURlCount";
            this.lblURlCount.Size = new System.Drawing.Size(13, 13);
            this.lblURlCount.TabIndex = 23;
            this.lblURlCount.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "تعداد پست ها :";
            // 
            // ScrollToGrab
            // 
            this.ScrollToGrab.Interval = 5000;
            this.ScrollToGrab.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // txtCommentText
            // 
            this.txtCommentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommentText.Location = new System.Drawing.Point(721, 36);
            this.txtCommentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommentText.Multiline = true;
            this.txtCommentText.Name = "txtCommentText";
            this.txtCommentText.Size = new System.Drawing.Size(205, 86);
            this.txtCommentText.TabIndex = 8;
            this.txtCommentText.Tag = "بالا";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "متن های ارسالی :";
            // 
            // lstCommentTexts
            // 
            this.lstCommentTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCommentTexts.FormattingEnabled = true;
            this.lstCommentTexts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstCommentTexts.Location = new System.Drawing.Point(97, 34);
            this.lstCommentTexts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCommentTexts.Name = "lstCommentTexts";
            this.lstCommentTexts.Size = new System.Drawing.Size(556, 95);
            this.lstCommentTexts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "متن جدید:";
            // 
            // btnAddTolist
            // 
            this.btnAddTolist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTolist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTolist.Location = new System.Drawing.Point(669, 61);
            this.btnAddTolist.Name = "btnAddTolist";
            this.btnAddTolist.Size = new System.Drawing.Size(46, 31);
            this.btnAddTolist.TabIndex = 13;
            this.btnAddTolist.Text = ">>";
            this.btnAddTolist.UseVisualStyleBackColor = true;
            this.btnAddTolist.Click += new System.EventHandler(this.txtAddTolist_Click);
            // 
            // btntxtLoad
            // 
            this.btntxtLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btntxtLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntxtLoad.Location = new System.Drawing.Point(9, 28);
            this.btntxtLoad.Name = "btntxtLoad";
            this.btntxtLoad.Size = new System.Drawing.Size(66, 28);
            this.btntxtLoad.TabIndex = 14;
            this.btntxtLoad.Text = "باز کردن";
            this.btntxtLoad.UseVisualStyleBackColor = true;
            this.btntxtLoad.Click += new System.EventHandler(this.btntxtLoad_Click);
            // 
            // btntxtSave
            // 
            this.btntxtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btntxtSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntxtSave.Location = new System.Drawing.Point(8, 63);
            this.btntxtSave.Name = "btntxtSave";
            this.btntxtSave.Size = new System.Drawing.Size(66, 28);
            this.btntxtSave.TabIndex = 15;
            this.btntxtSave.Text = "ذخیره کردن";
            this.btntxtSave.UseVisualStyleBackColor = true;
            this.btntxtSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(8, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "پاک کردن";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btntxtSave);
            this.groupBox3.Controls.Add(this.btntxtLoad);
            this.groupBox3.Controls.Add(this.btnAddTolist);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lstCommentTexts);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txtCommentText);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(8, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1030, 138);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مرحله 2 -تنظیم متون ارسالی";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::InstagramAutoComment.Properties.Resources.dac3e8773ec58ddc66d05041996e7aff_bot_o_bubble_do_chat_instagram_by_vexels;
            this.pictureBox2.Location = new System.Drawing.Point(935, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // richReport
            // 
            this.richReport.Font = new System.Drawing.Font("Tahoma", 8F);
            this.richReport.ForeColor = System.Drawing.Color.Maroon;
            this.richReport.Location = new System.Drawing.Point(6, 18);
            this.richReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richReport.Name = "richReport";
            this.richReport.Size = new System.Drawing.Size(268, 79);
            this.richReport.TabIndex = 0;
            this.richReport.Text = "";
            this.richReport.TextChanged += new System.EventHandler(this.richReport_TextChanged);
            // 
            // lblNumberItemSent
            // 
            this.lblNumberItemSent.AutoSize = true;
            this.lblNumberItemSent.Location = new System.Drawing.Point(12, 103);
            this.lblNumberItemSent.Name = "lblNumberItemSent";
            this.lblNumberItemSent.Size = new System.Drawing.Size(13, 13);
            this.lblNumberItemSent.TabIndex = 19;
            this.lblNumberItemSent.Text = "0";
            this.lblNumberItemSent.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "تعداد نظرات ارسالی :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblNumberItemSent);
            this.groupBox4.Controls.Add(this.richReport);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(8, 399);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(289, 125);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "گزارش";
            // 
            // btnStopSpamm
            // 
            this.btnStopSpamm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopSpamm.Location = new System.Drawing.Point(11, 83);
            this.btnStopSpamm.Name = "btnStopSpamm";
            this.btnStopSpamm.Size = new System.Drawing.Size(81, 34);
            this.btnStopSpamm.TabIndex = 1;
            this.btnStopSpamm.Text = "توقف ارسال";
            this.btnStopSpamm.UseVisualStyleBackColor = true;
            this.btnStopSpamm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartSpam
            // 
            this.btnStartSpam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartSpam.Location = new System.Drawing.Point(102, 83);
            this.btnStartSpam.Name = "btnStartSpam";
            this.btnStartSpam.Size = new System.Drawing.Size(81, 34);
            this.btnStartSpam.TabIndex = 10;
            this.btnStartSpam.Text = "شروع ارسال";
            this.btnStartSpam.UseVisualStyleBackColor = true;
            this.btnStartSpam.Click += new System.EventHandler(this.btnStartSpam_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "وقفه بین پست ها :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageEnable
            // 
            this.imageEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageEnable.AutoSize = true;
            this.imageEnable.Checked = true;
            this.imageEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imageEnable.Location = new System.Drawing.Point(80, 29);
            this.imageEnable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageEnable.Name = "imageEnable";
            this.imageEnable.Size = new System.Drawing.Size(113, 17);
            this.imageEnable.TabIndex = 20;
            this.imageEnable.Text = "دانلود نشدن تصاویر";
            this.imageEnable.UseVisualStyleBackColor = true;
            this.imageEnable.CheckedChanged += new System.EventHandler(this.imageEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "دقیقه";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTimeGap
            // 
            this.cmbTimeGap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTimeGap.FormattingEnabled = true;
            this.cmbTimeGap.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60"});
            this.cmbTimeGap.Location = new System.Drawing.Point(42, 53);
            this.cmbTimeGap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTimeGap.Name = "cmbTimeGap";
            this.cmbTimeGap.Size = new System.Drawing.Size(58, 21);
            this.cmbTimeGap.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cmbTimeGap);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.imageEnable);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.btnStartSpam);
            this.groupBox5.Controls.Add(this.btnStopSpamm);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox5.Location = new System.Drawing.Point(303, 399);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(293, 125);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "مرحله 4- پانل کنترل";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::InstagramAutoComment.Properties.Resources.panelControl;
            this.pictureBox4.Location = new System.Drawing.Point(201, 29);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-12, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(38, 17);
            this.listBox1.TabIndex = 22;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ckbGrabAll
            // 
            this.ckbGrabAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbGrabAll.AutoSize = true;
            this.ckbGrabAll.Checked = true;
            this.ckbGrabAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGrabAll.Location = new System.Drawing.Point(102, 24);
            this.ckbGrabAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbGrabAll.Name = "ckbGrabAll";
            this.ckbGrabAll.Size = new System.Drawing.Size(228, 17);
            this.ckbGrabAll.TabIndex = 25;
            this.ckbGrabAll.Text = "جمع آوری تصادفی آخرین مطالب ارسال شده";
            this.ckbGrabAll.UseVisualStyleBackColor = true;
            this.ckbGrabAll.CheckedChanged += new System.EventHandler(this.ckbGrabAll_CheckedChanged);
            // 
            // cknGrabHash
            // 
            this.cknGrabHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cknGrabHash.AutoSize = true;
            this.cknGrabHash.Location = new System.Drawing.Point(173, 45);
            this.cknGrabHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cknGrabHash.Name = "cknGrabHash";
            this.cknGrabHash.Size = new System.Drawing.Size(157, 17);
            this.cknGrabHash.TabIndex = 26;
            this.cknGrabHash.Text = "جمع آوری بر اساس هش تگ";
            this.cknGrabHash.UseVisualStyleBackColor = true;
            this.cknGrabHash.CheckedChanged += new System.EventHandler(this.cknGrabHash_CheckedChanged);
            // 
            // txtHashTag
            // 
            this.txtHashTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHashTag.Enabled = false;
            this.txtHashTag.Location = new System.Drawing.Point(158, 69);
            this.txtHashTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHashTag.Name = "txtHashTag";
            this.txtHashTag.Size = new System.Drawing.Size(139, 21);
            this.txtHashTag.TabIndex = 27;
            this.txtHashTag.TextChanged += new System.EventHandler(this.txtHashTag_TextChanged);
            this.txtHashTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHashTag_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "#";
            // 
            // btnHashTagStart
            // 
            this.btnHashTagStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHashTagStart.Enabled = false;
            this.btnHashTagStart.Location = new System.Drawing.Point(87, 67);
            this.btnHashTagStart.Name = "btnHashTagStart";
            this.btnHashTagStart.Size = new System.Drawing.Size(65, 25);
            this.btnHashTagStart.TabIndex = 7;
            this.btnHashTagStart.Text = "شروع";
            this.btnHashTagStart.UseVisualStyleBackColor = true;
            this.btnHashTagStart.Click += new System.EventHandler(this.btnHashTagStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnHashTagStart);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtHashTag);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblURlCount);
            this.groupBox6.Controls.Add(this.cknGrabHash);
            this.groupBox6.Controls.Add(this.ckbGrabAll);
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox6.Location = new System.Drawing.Point(602, 399);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(436, 125);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "مرحله 3- جمع آوری پست";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::InstagramAutoComment.Properties.Resources.explorer;
            this.pictureBox3.Location = new System.Drawing.Point(341, 29);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(153, 243);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "درباره ما";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(17, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "بروزرسانی نرم افزار";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(18, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Https://HSBTeam.com";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Instagram Auto Comment";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "نسخه : 1.5";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "برنامه نویس: هادی شیخ بکلو";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::InstagramAutoComment.Properties.Resources.logo2;
            this.pictureBox5.Location = new System.Drawing.Point(27, 16);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(92, 94);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1044, 532);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSB Instagram Auto Comment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timerefreshGrab;
        private System.Windows.Forms.Timer timerFunctionGrab;
        private System.Windows.Forms.Timer TimeCommenting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ClickToPostBtn;
        private System.Windows.Forms.WebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Timer ClickToCommentBtn;
        private System.Windows.Forms.Timer FillComment;
        private System.Windows.Forms.Label lblURlCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer ScrollToGrab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnHashTagStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHashTag;
        private System.Windows.Forms.CheckBox cknGrabHash;
        private System.Windows.Forms.CheckBox ckbGrabAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbTimeGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox imageEnable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnStartSpam;
        private System.Windows.Forms.Button btnStopSpamm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumberItemSent;
        public System.Windows.Forms.RichTextBox richReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btntxtSave;
        private System.Windows.Forms.Button btntxtLoad;
        private System.Windows.Forms.Button btnAddTolist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCommentTexts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCommentText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;



    }
}

