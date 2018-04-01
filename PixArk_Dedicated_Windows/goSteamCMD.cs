using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Compression;
using System.ComponentModel;
using System.Net;

namespace PixArk_Dedicated_Windows
{
    public class goSteamCMD
    {
        // async file download event monitor
        static ManualResetEvent mRE = new ManualResetEvent(false);
        // handle reset
        static void mRE_Done(object sender, EventArgs e)
        {
            mRE.Set();
        }
        
        // Main Initialization of SteamCMD working directory.
        public static Boolean parseSteamCMD(string rootDIR)
        {
            if(ExistanceSteamCMD(rootDIR) == true)
            {
                // return complete;
                return true;
            }
            else
            {
                getSteamCMD(rootDIR);
                return true;
            }
        }


        //Existance Check
        public static Boolean ExistanceSteamCMD(string rootDIR)
        {
            string isSteamCMD = rootDIR + "\\SteamCMD\\" + "steamcmd.exe";
            if(System.IO.File.Exists(isSteamCMD))
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        // Download SteamCMD
        public static void getSteamCMD(string rootDIR)
        {
            string fileName = rootDIR + "\\steamcmd.zip";
            WebClient client = new WebClient();
            Uri Uri = new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(mRE_Done);
            client.DownloadFileAsync(Uri, fileName);
            mRE.WaitOne();
        }

        // Extract steamcmd.exe to SteamCMD folder in rootDIR
        public void extractSteamCMD(string rootDIR, string fileName)
        {
            // define the strings used for directory pathing and file pathing.
            string FilePath = rootDIR + "\\" + "SteamCMD" + "\\";
            string SteamCMDChecker = FilePath + "steamcmd.exe";

            if (!System.IO.File.Exists(SteamCMDChecker))
            {
                ZipFile.ExtractToDirectory(fileName, FilePath);
            }           
        }
    }
}
