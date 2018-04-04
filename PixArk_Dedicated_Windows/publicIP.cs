using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixArk_Dedicated_Windows
{
    public partial class publicIP : Form
    {
        public publicIP()
        {
            InitializeComponent();
        }
        public String myIP;
        private void publicIP_Load(object sender, EventArgs e)
        {
            myIP = IPINFO.Text; //-- your result
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            IPINFO.Text = a4;
            IPINFO.Refresh();
        }        
    }
}
