using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
namespace ProxyScrap
{
    public partial class Form1 : Form
    {
        string pattern = @"(\d{1,3}\.){3}\d{1,3}:\d{2,5}";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(pattern);
            for (int i=0;i<linksBOx.Lines.Length;i++)
            {
                if (reg.IsMatch(linksBOx.Lines[i])) proxyBox.Text += linksBOx.Lines[i] + "\n";

            }
           /* MatchCollection matches = reg.Matches(p);
            for (int i = 0; i < matches.Count; i++)
            {
                MessageBox.Show(matches[i].ToString());
                proxyBox.Text += matches[i].ToString() + "\n";
            }*/
           /* WebClient client = new WebClient();
            int nProxy  = proxyBox.Lines.Length;
            for (int i=0;i<nProxy;i++)
            {
                string page = client.DownloadString(proxyBox.Lines[i]);

            }*/
            
        }
    }
}
