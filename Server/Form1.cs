using Common.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private Server server;
        public Form1()
        {
            InitializeComponent();
            btnzaustavi.Enabled = false;
            label1.Text = "Server je zaustavljen!";
        }

        private void pokreni_Click(object sender, EventArgs e)
        {
            server = new Server();
            btnpokreni.Enabled = false;
            btnzaustavi.Enabled = true;
            label1.Text = "Server je pokrenut!";
            server.Start();
        }

        private void btnzaustavi_Click(object sender, EventArgs e)
        {

            btnpokreni.Enabled = true;
            btnzaustavi.Enabled = false;
            label1.Text = "Server je zaustavljen!";
            server.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);    
        }
    }
}
