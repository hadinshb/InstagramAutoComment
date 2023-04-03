using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Net;


namespace InstagramAutoComment
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
         
                         
        }
        double ver_app=1.5;
        bool StartSpamming = false;
        int totalItemSent = 0;
        string commnetToSend;
        bool GrabHashTagFlag = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var Respons = string.Empty;
                double new_ver = 0;
                using (var web = new System.Net.WebClient())
                    Respons = web.DownloadString("https://hsbteam.com/myprojects/instagramautocomment/update/lastver.txt");
                if (Respons != null && Respons.Contains("ver:"))
                {
                    new_ver = double.Parse(Respons.Replace("ver:", "").Trim());
                    if (new_ver <= ver_app)
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("نسخه جدید در دسترس می باشد", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var dialog = new SaveFileDialog();
                        dialog.Filter = "Archive (*.zip)|*.zip";
                        dialog.FileName = "instagram_auto_comment";

                        var result = dialog.ShowDialog(); //shows save file dialog
                        if (result == DialogResult.OK)
                        {
                            // Console.WriteLine("writing to: " + dialog.FileName); //prints the file to save

                            var wClient = new WebClient();
                            wClient.DownloadFile("https://hsbteam.com/myprojects/instagramautocomment/update/instagram_auto_comment.zip", dialog.FileName);
                            MessageBox.Show("با موفقیت ذخیره شد،برنامه را از مسیر ذخیره شده اجرا کنید", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }

                    }
                }
                else
                {
                   
                }


            }
            catch (Exception exp)
            {

                if (exp.Message.Contains("resolved"))
                {
                    MessageBox.Show("ارتباط با سرور مقدور نیست.ارتباط شبکه ای خود را بازبینی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            
           // geckoWebBrowser1.Navigate("https://www.instagram.com/p/BUtc8vBA6MW/?", null, null,
                //   "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            cmbTimeGap.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richReport.Text="عملیات قطع شد...\n";
            btnStopSpamm.Enabled = false;
            btnStartSpam.Enabled = true;
            richReport.ScrollToCaret();
            StartSpamming = false;
            TimeCommenting.Stop();
            timerefreshGrab.Stop();
            timerFunctionGrab.Stop();
            groupBox6.Enabled = true;
            groupBox3.Enabled = true;
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // geckoWebBrowser1_old.Navigate("http://instagram.com/accounts/login");
            geckoWebBrowser1.Navigate("http://instagram.com/accounts/login", null, null,
                   "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            richReport.Clear();



            richReport.AppendText("درحال ورود به صفحه اینستاگرام ...\n");
            richReport.ScrollToCaret();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           // geckoWebBrowser1_old.Navigate("https://www.instagram.com/accounts/logout/");
            geckoWebBrowser1.Navigate("https://www.instagram.com/accounts/logout/", null, null,
                 "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            timerefreshGrab.Start();
            timerFunctionGrab.Start();
        }

         void grabUrls()
        {
            try
            {
                if ((geckoWebBrowser1.Url.ToString()+".").Contains("/explore"))
                {
                    richReport.AppendText("درحال آنالیز پست ها...\n");
                    richReport.ScrollToCaret();

                    for (int i = 0; i < geckoWebBrowser1.Document.Links.Count; i++)
                    {
                        int count = listBox1.Items.Count;
                        // MessageBox.Show(geckoWebBrowser1.Document.Links[i].GetAttribute("href").ToString());
                        if (geckoWebBrowser1.Document.Links[i].GetAttribute("href").ToString().Contains("/p/"))
                        {
                            string link = geckoWebBrowser1.Document.Links[i].GetAttribute("href").ToString();

                            if (!listBox1.Items.Contains(link))
                            {
                                listBox1.Items.Add(geckoWebBrowser1.Document.Links[i].GetAttribute("href").ToString());
                                lblURlCount.Text = listBox1.Items.Count.ToString();
                             
                            }
                        }
                        if (count != listBox1.Items.Count)
                        {
                            richReport.AppendText("حذف پست های تکراری...\n");
                            richReport.AppendText("پست ها اضافه شد...\n");
                            richReport.ScrollToCaret();
                        }
                      
                    }

                   
                }
               
            }
            catch { }
        }

        private void timerefreshGrab_Tick(object sender, EventArgs e)
        {
            
            geckoWebBrowser1.Navigate("https://www.instagram.com/explore/", null, null,
                 "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
        }

        private void timerFunctionGrab_Tick(object sender, EventArgs e)
        {
            grabUrls();
    
            if (listBox1.Items.Count >5)
            {
                timerefreshGrab.Stop();
                timerFunctionGrab.Stop();
               
                TimeCommenting.Interval = 5000;
    
                TimeCommenting.Start();

            }
        }

        private void btnStopGrab_Click(object sender, EventArgs e)
        {
            timerefreshGrab.Stop();
            timerFunctionGrab.Stop();
        }
 

        private void btnStartSpam_Click(object sender, EventArgs e)
        {
            if(lstCommentTexts.Items.Count==0)
            {
                MessageBox.Show("ابتدا متن های ارسالی خود  را وارد  کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                richReport.Text = "عملیات آغاز شد...\n";
                btnStopSpamm.Enabled = true;
                btnStartSpam.Enabled = false;
                richReport.ScrollToCaret();
            richReport.ScrollToCaret();
            TimeCommenting.Interval = 3000;
            TimeCommenting.Start();
            groupBox3.Enabled = false;
            groupBox6.Enabled = false;
            }
         
        }

        private void TimeCommenting_Tick(object sender, EventArgs e)
        {
            try
            {
             
                if (listBox1.Items.Count < 2)
                {
                    if(cknGrabHash.Checked&&StartSpamming)
                    {
                        richReport.Text="ارسال با موفقیت به پایان رسید...\n";
                        richReport.ScrollToCaret();
                        TimeCommenting.Stop();
                        StartSpamming = false;
                        listBox1.Items.Clear();
                        lblURlCount.Text = "0";
                        groupBox3.Enabled = true;
                        groupBox6.Enabled = true;
                    }
                    else if (cknGrabHash.Checked && !StartSpamming)
                    {
                        TimeCommenting.Stop();
                        StartSpamming = false;
                        richReport.Text = "عملیات متوقف شد...\n";
                        richReport.ScrollToCaret();
                        MessageBox.Show("ابتدا پست ها را جمع آوری کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        groupBox3.Enabled = true;
                        groupBox6.Enabled = true;
                    }
                    else
                    {
                        TimeCommenting.Stop();
                        StartSpamming = false;
                        richReport.AppendText("در حال جمع آوری جدیدترین پست های ارسال شده...\n");
                        richReport.ScrollToCaret();
                        timerefreshGrab.Start();
                        timerFunctionGrab.Start();
                    }
                 
                  

                }
                else
                {
                    TimeCommenting.Interval =int.Parse( (float.Parse(cmbTimeGap.SelectedItem.ToString()) * 60000+10000).ToString());
                   
                 
                    richReport.Text="در حال ارسال نظر...\n";
                    richReport.ScrollToCaret();
                    StartSpamming = true;
                    if (listBox1.SelectedIndex + 1 < listBox1.Items.Count)
                    {
                        listBox1.SelectedIndex++;
                    }
                    else
                    {
                        listBox1.SelectedIndex = 0;
                    }
                }
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAddTolist_Click(object sender, EventArgs e)
        {
            if (txtCommentText.Text.Trim() != "")
            {
                lstCommentTexts.Items.Add(txtCommentText.Text);
                txtCommentText.Text = "";
                txtCommentText.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                lstCommentTexts.Items.Remove(lstCommentTexts.SelectedItem);
                lstCommentTexts.SelectedIndex++;
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "ذخیره متون ارسالی";
                save.Filter = "HSB CommentText Files|*.hsb";
                save.ShowDialog();

                if (save.FileName == "") { }
                else
                {

                    int Line = lstCommentTexts.Items.Count;
                    StreamWriter sw = new StreamWriter(save.FileName);

                    for (int i = 0; i < Line; i++)
                    {
                        sw.WriteLine(lstCommentTexts.Items[i]);
                    }


                    sw.Close();
                }
            }
            catch { }
        }

        private void btntxtLoad_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog OpenFile = new OpenFileDialog();

                OpenFile.Title = "وارد کردن متون ارسالی";
                OpenFile.Filter = "HSB CommentText Files|*.hsb";
                OpenFile.ShowDialog();

                if (OpenFile.FileName != "")
                {
                    StreamReader sr = new StreamReader(OpenFile.FileName);

                    for (int i = 0; i < 5000; i++)
                    {
                        string temp = sr.ReadLine();
                        if (temp != "")
                        {
                            lstCommentTexts.Items.Add(temp.Trim());
                        }
                    }




                    sr.Close();

                }
            }
            catch { }
        }
 



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void imageEnable_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void lblURlCount_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void geckoWebBrowser1_Click_3(object sender, EventArgs e)
        {

        }

        

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ClickToPostBtn.Stop();
                   var button = geckoWebBrowser1.Document.GetElementsByTagName("button");
                foreach (HtmlElement btn in button)
                {
                    if (btn.InnerHtml.ToString().Trim()=="Post")
                    
                    {

                        btn.InvokeMember("click");

                        richReport.Clear();
                        richReport.AppendText("ارسال انجام شد...\n");
                        richReport.AppendText("انتظار برای جلوگیری از تشخیص اسپم...\n");
                        totalItemSent++;
                        lblNumberItemSent.Text = totalItemSent.ToString();
                        richReport.ScrollToCaret();

                    }
                }
              
            }
            catch { }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           try
            {



             


                var images = geckoWebBrowser1.Document.GetElementsByTagName("img");

                foreach (HtmlElement img in images)
                {
                    img.SetAttribute("src", "");
                        img.SetAttribute("srcset","");
                }
            
                if (StartSpamming)
                {
                    if (geckoWebBrowser1.Url.ToString().Contains("instagram.com/p/"))
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        lblURlCount.Text = listBox1.Items.Count.ToString();

                        Random rnd = new Random();
                        int random = rnd.Next(0, lstCommentTexts.Items.Count - 1);
                        //  DateTime time = DateTime.Now;
                         commnetToSend = lstCommentTexts.Items[random].ToString() + ' ';
                        lstCommentTexts.SelectedIndex = random;
                        Random rnd2Dot = new Random();
                        int temp = rnd2Dot.Next(1, 6);

                        for (int i = 0; i < temp; i++)
                        {

                            commnetToSend = "🌸" + commnetToSend;
                        }


                         temp = rnd2Dot.Next(1, 10);
                         for (int i = 0; i < temp; i++)
                         {

                             commnetToSend =  commnetToSend+"🌸";
                         }

                     
                                            

                        ClickToCommentBtn.Start();
 

                    }
                }
            }
            catch {  }

        }

        private void ClickToCommentBtn_Tick(object sender, EventArgs e)
        {
             try
            {
                ClickToCommentBtn.Stop();
                 //OLD Code
                //var linkButton = geckoWebBrowser1.Document.GetElementsByTagName("a");
                //int count = 0;
                //foreach (HtmlElement link in linkButton)
                //{
                //    if (link.GetAttribute("role").Contains("button"))
                //    {
                //        string temp = link.InnerHtml+".";
                     
                //        if (temp.Contains("Comment"))
                //        {
                //            link.InvokeMember("click");
                //            count++;
                //        }
                //    }
                //}

                 //New Code
                var linkButton = geckoWebBrowser1.Document.GetElementsByTagName("button");
                int count = 0;
                foreach (HtmlElement link in linkButton)
                {
                    if (link.InnerHtml.Contains("aria-label=\"Comment\""))
                    {
                    
                        {
                            link.InvokeMember("click");
                            count++;
                        }
                    }
                }




                 if(count==0)
                 {
                     richReport.AppendText("کامنت برای این پست بسته می باشد...\n");
                    
                    
                 }
                FillComment.Start();
                
            }
           catch { }
        }

        private void FillComment_Tick(object sender, EventArgs e)
        {

            try
            {
                FillComment.Stop();
                geckoWebBrowser1.Document.GetElementsByTagName("textarea")[0].SetAttribute("value", commnetToSend);
                geckoWebBrowser1.Document.GetElementsByTagName("textarea")[0].SetAttribute("class", "none");
                geckoWebBrowser1.Document.GetElementsByTagName("textarea")[0].InnerText = commnetToSend;
              
                ClickToPostBtn.Start();
            }
            catch { }
        }

        private void geckoWebBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                if (imageEnable.Checked) {


                    var images = geckoWebBrowser1.Document.GetElementsByTagName("img");

                    foreach (HtmlElement img in images)
                    {
                        img.SetAttribute("src", "");
                        img.SetAttribute("srcset", "");
                    }
                }
                else
                { }
               

            }
            catch { }
        }

        private void txtHashTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHashTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = '_';
               
            }
        }
 
        private void ckbGrabAll_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbGrabAll.Checked)
            {
                cknGrabHash.Checked = false;
                btnHashTagStart.Enabled = false;
                txtHashTag.Enabled = false;
                ScrollToGrab.Stop();
                btnHashTagStart.Text = "شروع";
                GrabHashTagFlag = false;
                groupBox5.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {
                cknGrabHash.Checked =true;
                btnHashTagStart.Enabled = true;
                txtHashTag.Enabled = true;
            }
        }

        private void cknGrabHash_CheckedChanged(object sender, EventArgs e)
        {
            if (cknGrabHash.Checked)
            {
                ckbGrabAll.Checked = false;
                btnHashTagStart.Enabled = true;
                txtHashTag.Enabled = true;
                
            }
            else
            {
                btnHashTagStart.Text = "شروع";
                GrabHashTagFlag = false;
               ckbGrabAll.Checked  = true;
               btnHashTagStart.Enabled = false;
                txtHashTag.Enabled = false;
                ScrollToGrab.Stop();
            }
        }

        private void btnHashTagStart_Click(object sender, EventArgs e)
        {
            if (txtHashTag.Text == "")
            {
                MessageBox.Show("ابتدا هش تگ را وارد کنید...", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (GrabHashTagFlag)
                {
                    ScrollToGrab.Stop();
                    btnHashTagStart.Text = "شروع";
                    GrabHashTagFlag = false;

                    richReport.Clear();



                    richReport.AppendText("جمع آوری متوقف شد ...\n");
                    richReport.ScrollToCaret();
                    groupBox5.Enabled = true;
                     
                    groupBox3.Enabled = true;

                }
                else
                {
                    geckoWebBrowser1.Navigate("https://www.instagram.com/explore/tags/" + txtHashTag.Text + "/", null, null,
                 "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                    ScrollToGrab.Start();
                    btnHashTagStart.Text = "توقف";
                    GrabHashTagFlag = true;

                    richReport.Clear();

                    groupBox5.Enabled = false;
                    groupBox3.Enabled = false;
              
                    richReport.AppendText("درحال جمع آوری پست ها بر اساس هش تگ ...\n");
                         richReport.ScrollToCaret();
                }
              
               
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
            
                geckoWebBrowser1.Document.Window.ScrollTo(0, 1900000000);
                grabUrls();
                richReport.AppendText("درحال جمع آوری پست ها بر اساس هش تگ ...\n");
            }
            catch { }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (StartSpamming)
                {
                    geckoWebBrowser1.Navigate("https://www.instagram.com" + listBox1.SelectedItem.ToString(), null, null,
                     "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                    // geckoWebBrowser1_old.Navigate("https://www.instagram.com"+listBox1.SelectedItem.ToString());
                }
            }
            catch { }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.HSBTeam.com");
            }
            catch (Win32Exception)
            {
                Process.Start("IExplore.exe", "https://www.HSBTeam.com");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var Respons = string.Empty;
                double new_ver = 0 ;
                using (var web = new System.Net.WebClient())
                    Respons = web.DownloadString("https://hsbteam.com/myprojects/instagramautocomment/update/lastver.txt");
                if(Respons!=null&&Respons.Contains("ver:"))
                {
                    new_ver=float.Parse(Respons.Replace("ver:", "").Trim());
                    if (new_ver <= ver_app)
                    {
                        MessageBox.Show("نسخه شما،در حال حاضر آخرین نسخه می باشد", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("نسخه جدید در دسترس می باشد", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var dialog = new SaveFileDialog();
                        dialog.Filter = "Archive (*.zip)|*.zip";
                        dialog.FileName = "instagram_auto_comment";

                        var result = dialog.ShowDialog(); //shows save file dialog
                        if (result == DialogResult.OK)
                        {
                           // Console.WriteLine("writing to: " + dialog.FileName); //prints the file to save

                            var wClient = new WebClient();
                            wClient.DownloadFile("https://hsbteam.com/myprojects/instagramautocomment/update/instagram_auto_comment.zip", dialog.FileName);
                            MessageBox.Show("با موفقیت ذخیره شد،برنامه را از مسیر ذخیره شده اجرا کنید", "اعلان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("ارتباط با سرور مقدور نیست", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }
            catch(Exception exp)
            { 
                
                if(exp.Message.Contains("resolved"))
                {
                    MessageBox.Show("ارتباط با سرور مقدور نیست.ارتباط شبکه ای خود را بازبینی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            
            
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.instagram.com/p/BUoTNOTgMVXXJ08sj8GmQgfqvOVTsXjECEf33g0/", null, null,
                   "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              






                var button = geckoWebBrowser1.Document.GetElementsByTagName("button");
                foreach (HtmlElement btn in button)
                {
                    if (btn.InnerHtml.ToString().Trim()=="Post")
                    {

                        btn.InvokeMember("click");

                        richReport.Clear();
                        richReport.AppendText("ارسال انجام شد...\n");
                        richReport.AppendText("انتظار برای جلوگیری از تشخیص اسپم...\n");
                        totalItemSent++;
                        lblNumberItemSent.Text = totalItemSent.ToString();
                        richReport.ScrollToCaret();

                    }
                }
               
            }
            catch { }
        }
      
      
      
  
    }
}
