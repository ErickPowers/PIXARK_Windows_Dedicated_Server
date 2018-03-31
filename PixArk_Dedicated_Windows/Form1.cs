using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using IWshRuntimeLibrary;

namespace PixArk_Dedicated_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String PIXARKPATH;
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    PIXARKPATH = folderDialog.SelectedPath; //-- your result
                    Server_Path.Text = PIXARKPATH + "\\";
                    Server_Path.Refresh();
                    fileName = PIXARKPATH + "\\steamcmd.zip";
                    // now get the file.
                    WebClient client = new WebClient();
                    Uri Uri = new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    client.DownloadFileAsync(Uri, fileName);
                    
                }
            }
        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }
        public String fileName;
        public String PIXARKSRVNAME;
        private void Next1_Click(object sender, EventArgs e)
        {
 
           

        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // blowup the screen with an annoyingly worded, and hard to read message!
            string FilePath = PIXARKPATH + "\\" + PIXARKSRVNAME + "\\";
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            MessageBox.Show("STEAMCMD.zip has been downloaded to the following location: " + PIXARKPATH + "\\ " + "\n" + "Now Launching STEAMCMD and Downloading PIXARK " + "\n" + " *Please note that you need at least 4~ GB free space for this.");
            string filechecker = PIXARKPATH + "\\steamcmd\\" + "steamcmd.exe";
            if (System.IO.File.Exists(filechecker))
            {
                MessageBox.Show("You already have SteamCMD, skipping to running "+ PIXARKSRVNAME +" setup.");
            }
            else
            {
                ZipFile.ExtractToDirectory(fileName, PIXARKPATH + "\\steamcmd\\");
            }
            string strCmdText; 
            StreamWriter w = new StreamWriter(PIXARKPATH + "\\steamcmd\\get_pixark.bat");
            w.WriteLine("\"" + PIXARKPATH + "\\steamcmd\\steamcmd.exe" + "\" " + "+exit");
            w.WriteLine("\"" + PIXARKPATH + "\\steamcmd\\steamcmd.exe" + "\" " + "+login anonymous +force_install_dir " + "\""+ PIXARKPATH + "\\" + PIXARKSRVNAME +"\"" + " +app_update 824360 validate +exit");
            w.WriteLine("exit");
            w.Close();
            strCmdText = PIXARKPATH + "\\steamcmd\\get_pixark.bat";
            System.Diagnostics.Process.Start(strCmdText);
            button2.Enabled = true;
            // Create the launcher batch file
            string srvStart = "start \"\" /NORMAL \"" + PIXARKPATH + "\\" + PIXARKSRVNAME + "\\ShooterGame\\Binaries\\Win64\\PixARKServer.exe\" \"CubeWorld_Light?listen?MaxPlayers=10?Port=27015?QueryPort=27016?RCONPort=27017?SessionName=" + PIXARKSRVNAME + "?ServerAdminPassword=YOURADMINPASSWORD?CULTUREFORCOOKING=en\" -NoBattlEye -NoHangDetection -CubePort=27016 -cubeworld=YOURWORLDNAME -Seed=YOURRANDOMSEED -nosteamclient -game -server -log";
            StreamWriter w2 = new StreamWriter(PIXARKPATH + "\\" + PIXARKSRVNAME + "\\" + PIXARKSRVNAME + "_Server_Launcher.bat");
            w2.WriteLine(srvStart);
            w2.Close();
            // Checked to see if we Checked that Checkbox for our launcher. 
            if (desktopSC.Checked)
            {
                var startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var shell = new WshShell();
                var shortCutLinkFilePath = Path.Combine(startupFolderPath, "" + PIXARKSRVNAME + "_Server.lnk");
                var windowsApplicationShortcut = (IWshShortcut)shell.CreateShortcut(shortCutLinkFilePath);
                windowsApplicationShortcut.Description = "This is a link to the PIXARK Server";
                windowsApplicationShortcut.WorkingDirectory = "\"" + PIXARKPATH + "\\" + PIXARKSRVNAME + "\\";
                windowsApplicationShortcut.TargetPath = "\"" + PIXARKPATH + "\\" + PIXARKSRVNAME + "\\" + PIXARKSRVNAME + "_Server_Launcher.bat" + "\"";
                windowsApplicationShortcut.Save();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PIXARKSRVNAME = srvdir.Text;
            if (PIXARKSRVNAME != null) {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srvdir_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
        
         private void button2_Click(object sender, EventArgs e)
        {
            /**  // Need to add the ability to change parameters through the GUI next time I feel like updating this. Some users will have issues with this whole thing anyway.
              string srvStart = "start \"\" /NORMAL \""+ PIXARKPATH + "\\"+ PIXARKSRVNAME + "\\ShooterGame\\Binaries\\Win64\\PixARKServer.exe\" \"CubeWorld_Light?listen?MaxPlayers=10?Port=27015?QueryPort=27016?RCONPort=27017?SessionName=" + PIXARKSRVNAME + "?ServerAdminPassword=YOURADMINPASSWORD?CULTUREFORCOOKING=en\" -NoBattlEye -NoHangDetection -CubePort=27018 -cubeworld=YOURWORLDNAME -Seed=YOURRANDOMSEED -nosteamclient -game -server -log";
              StreamWriter w2 = new StreamWriter(PIXARKPATH + "\\" + PIXARKSRVNAME + "\\" + PIXARKSRVNAME + "_Server_Launcher.bat");
              w2.WriteLine(srvStart);
              w2.Close();

              var startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
              var shell = new WshShell();
              var shortCutLinkFilePath = Path.Combine(startupFolderPath, ""+ PIXARKSRVNAME + "_Server.lnk");
              var windowsApplicationShortcut = (IWshShortcut)shell.CreateShortcut(shortCutLinkFilePath);
              windowsApplicationShortcut.Description = "This is a link to the PIXARK Server";
              windowsApplicationShortcut.WorkingDirectory = "\"" + PIXARKPATH + "\\" + PIXARKSRVNAME + "\\";
              windowsApplicationShortcut.TargetPath = "\"" + PIXARKPATH + "\\" + PIXARKSRVNAME + "\\" + PIXARKSRVNAME + "_Server_Launcher.bat" + "\"";
              windowsApplicationShortcut.Save();
            **/
              this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
