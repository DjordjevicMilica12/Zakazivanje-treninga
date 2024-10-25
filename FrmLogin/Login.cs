using FrmLogin.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.Text = "mirela.cebic";
            txtPassword.Text = "lozinka123";
            // btnLogin.Click += LoginGUIController.Instance.Login;
            this.BackColor = Color.FromArgb(249, 231, 249);
            lblText.Text = "Molimo vas unesite svoje korisnicno ime, lozinku i izaberite ulogu";
            lblText.Font = new Font("Arial", 8, FontStyle.Bold);
        }
        Uloge u=new Uloge();
        private void btnLogin_Click(object sender, EventArgs e)
        {
          

            if (rdbRoditelj.Checked)
            {
                u = Uloge.roditelj;
            LoginGUIController.Instance.Login(sender,e,u);
            }
            if(rdbTrener.Checked)
            {
                u = Uloge.trener;
            LoginGUIController.Instance.Login(sender,e, u);
            }
            if(!rdbTrener.Checked && !rdbRoditelj.Checked)
            {
                MessageBox.Show("Morate izabrati ulogu!");
            }
        }
    }
}
