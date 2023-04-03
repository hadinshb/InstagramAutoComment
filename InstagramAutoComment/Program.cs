using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InstagramAutoComment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
            System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

            try
            {
                foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
                {
                    StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\info.dat");
                    string text = sr.ReadLine();
                    sr.Close();
                    if(text!="")
                    {
                        string email=text.Split('|')[0];
                        string cpu_id = text.Split('|')[1];
                        if(currentResult["ProcessorID"].ToString()==cpu_id)
                        {

                            try
                            {
                                var Respons = string.Empty;

                                using (var web = new System.Net.WebClient())
                                    Respons = web.DownloadString("https://hsbteam.com/myprojects/instagramautocomment/register/checker.php?email=" + email);
                                if (Respons != null)
                                {
                                    if(Respons.Contains("not payment"))
                                    {
                                        Application.Run(new Activation()); 
                                    }
                                    else if(Respons.Contains("block"))
                                    {
                                        MessageBox.Show("دسترسی شما مسدود شده است.با مدیریت در ارتباط باشید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                    else if(Respons.Contains("run"))
                                    {
                                        Application.Run(new Form1()); 
                                    }
                                }
                            }
                            catch (Exception exp)
                            {

                                if (exp.Message.Contains("resolved"))
                                {
                                    MessageBox.Show("ارتباط با سرور مقدور نیست.ارتباط شبکه ای خود را بازبینی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Application.Exit();
                                }
                            }

                        }
                        else
                        {
                            Application.Run(new Activation()); 
                        }
                    }
                    else
                    {
                        Application.Run(new Activation()); 
                    }
                        
                        
                   


                  

                    break;
                }
            }
            catch { Application.Run(new Activation()); }
           
        }
    }
}
