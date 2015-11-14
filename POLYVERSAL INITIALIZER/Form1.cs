using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CUBE_Launcher
{
    public partial class Form1 : Form
    {
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        System.Net.WebClient wc = new System.Net.WebClient();

        private void Initialize_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!System.IO.Directory.Exists(appdata + "\\CUBE"))
            {
                System.IO.Directory.CreateDirectory(appdata + "\\CUBE");
            }
            if (!System.IO.Directory.Exists(documents + "\\Zero"))
            {
                System.IO.Directory.CreateDirectory(documents + "\\Zero");
            }
            if(!System.IO.File.Exists(documents + "\\Zero\\ConfigurationV3.data"))
            {
                System.IO.File.WriteAllText(documents + "\\Zero\\ConfigurationV3.data", wc.DownloadString("http://team-ivan.com/blog/ConfigurationV3.txt").Replace("<reswidth>", SystemInformation.PrimaryMonitorSize.Width.ToString()).Replace("<resheight>", SystemInformation.PrimaryMonitorSize.Height.ToString()));
            }
            try
            {
                wc.DownloadFile("http://team-ivan.com/blog/cube_welcome.txt", appdata + "\\CUBE\\welcome.txt");
            } catch { }
            if (System.IO.Directory.Exists(appdata + "\\CUBE") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "\\CUBE");
            }
            try
            {
                if (!System.IO.File.Exists(appdata + "\\CUBE\\rev.txt") || !(wc.DownloadString("http://team-ivan.com/blog/cube_rev.txt") == System.IO.File.ReadAllText(appdata + "\\CUBE\\rev.txt")))
                {
                    wc.DownloadFile("http://team-ivan.com/blog/CUBE.exe", appdata + "\\CUBE\\CUBE.exe");
                }
            }
            catch { }
            try
            {
                wc.DownloadFile("http://team-ivan.com/blog/cube_rev.txt", appdata + "\\CUBE\\rev.txt");
            } catch { }
            if (System.IO.Directory.Exists(appdata + "\\CUBE") == false)
            {
                System.IO.Directory.CreateDirectory(appdata + "\\CUBE");
            }
            if(!System.IO.File.Exists(appdata + "\\CUBE\\CUBE.exe"))
            {
                Label1.Text = "Connect to\r\nthe Internet!";
            }
        }

        private string RandImage()
        {
            while (true)
            {
                int time = Math.Abs((int)(DateTime.Now.Ticks / 1000) % 9);
                if (!(time == 9) && !(time == 0))
                {
                    return time.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingIcon.BringToFront();
            LoadingIcon.Visible = true;
            LoadingIcon.Location = new System.Drawing.Point(0, 0);
            Button1.Enabled = false;
            PictureBox1.Image = (System.Drawing.Image)CUBE_Launcher.Properties.Resources.ResourceManager.GetObject("_" + RandImage());
            Initialize.RunWorkerAsync();
        }

        private void Initialize_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                Label1.Text = System.IO.File.ReadAllText(appdata + "\\CUBE\\welcome.txt");
                for (int i = 0; i <= 20; i++)
                {
                    Label1.Text += "\r\n";
                }
            }
            catch { }
            LoadingIcon.Visible = false;
            LoadingIcon.Location = new System.Drawing.Point(0, 425);
            Button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(appdata + "\\CUBE\\CUBE.exe") == false)
            {
                MessageBox.Show("You need to have connected to the Internet at least once to play CUBE!");
            }
            else
            {
                try
                {
                    Process loa = Process.Start(appdata + "\\CUBE\\CUBE.exe", "-nolauncher");
                    loa.PriorityClass = ProcessPriorityClass.AboveNormal; //"optimizes" for crappy hardware
                    this.Close();
                }
                catch
                {
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}