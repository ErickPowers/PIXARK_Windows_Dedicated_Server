using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixArk_Dedicated_Windows
{
    class BatchFileWriter
    {
        public static void batSteamCMD(string rootDIR)
        {

        }

        // 
        public static void pixarkLauncher(string rootDIR, string PixArkSrv)
        {
            string srvStart = "start \"\" /NORMAL \"" + rootDIR + "\\" + PixArkSrv + "\\ShooterGame\\Binaries\\Win64\\PixARKServer.exe\" \"CubeWorld_Light?listen?MaxPlayers=10?Port=27015?QueryPort=27016?RCONPort=27017?SessionName=" + PIXARKSRVNAME + "?ServerAdminPassword=YOURADMINPASSWORD?CULTUREFORCOOKING=en\" -NoBattlEye -NoHangDetection -CubePort=27018 -cubeworld=YOURWORLDNAME -Seed=YOURRANDOMSEED -nosteamclient -game -server -log";

            // parameters that need to be set, need to be able to toggle srvServerPassword

            string srvMaxPlayers;
            string srvPort;
            string srvQueryPort;
            string srvRCONPORT;
            
            // session name is what will show up in the server browser listing.
            string srvSessionName;

            string srvServerAdminPassword;
            string srvCULTUREFORCOOKING;

            // optional server password
            string srvServerPassword;

            // switches at the end of the special parms

            string srvSeedName;
            string srvWorldName;

            string srvParmBeginning = "start \"\" /NORMAL \"" + rootDIR + "\\" + PixArkSrv + "\\ShooterGame\\Binaries\\Win64\\PixARKServer.exe\" ";
            string srvParmMiddle = "\"CubeWorld_Light?listen?" + srvMaxPlayers + "?" + srvPort + "?" + srvQueryPort + "?" + srvRCONPORT + "?" + srvSessionName + "?" + srvServerAdminPassword + "?" + srvCULTUREFORCOOKING + "\"";
            string srvParmEnd = "";
            StreamWriter w2 = new StreamWriter(PIXARKPATH + "\\" + PIXARKSRVNAME + "\\" + PIXARKSRVNAME + "_Server_Launcher.bat");
            w2.WriteLine(srvStart);
            w2.Close();
        }
    }
}
