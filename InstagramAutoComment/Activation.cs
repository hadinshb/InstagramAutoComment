using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstagramAutoComment
{
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "")
                {
                    var Respons = string.Empty;
                
                    using (var web = new System.Net.WebClient())
                        Respons = web.DownloadString("https://hsbteam.com/myprojects/instagramautocomment/register/reg.php?email="+txtEmail.Text);
                    if(Respons!=null )
                    {
                        if(Respons.Contains("not payment"))
                        {
                            MessageBox.Show("ایمیل وارد شده در سیستم ثبت نشده است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if(Respons.Contains("paied"))
                        {


                            System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
                            System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

                            foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
                            {
                                 string text = txtEmail.Text+'|'+ currentResult["ProcessorID"].ToString();
                                 StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\info.dat");

                                 
                                     sw.WriteLine(text);
                               
                                 sw.Close();
                                 MessageBox.Show("عملیات فعالسازی با موفقیت انجام شد.برنامه را مجددا اجرا فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 Application.Exit();
                                
                                break;
                            }
                        }
                        else if(Respons.Contains("max_activation"))
                        {
                            MessageBox.Show("شما بیش از حد مجاز نرم افزار را فعال سازی کرده اید.با پشتیبانی در تماس باشید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("ایمیل را وارد کنید و سپس این دکمه را فشار دهید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exp)
            {

                if (exp.Message.Contains("resolved"))
                {
                    MessageBox.Show("ارتباط با سرور مقدور نیست.ارتباط شبکه ای خود را بازبینی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnActive_Click(null, null);
            }
        }
    }
}
