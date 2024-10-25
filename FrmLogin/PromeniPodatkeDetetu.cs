using Common.Domain;
using Common;
using FrmLogin.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Communication;

namespace FrmLogin
{
    public partial class PromeniPodatkeDetetu : Form
    {
        Roditelj roditelj;
        public PromeniPodatkeDetetu(Roditelj r)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(249, 231, 249);
            label5.Font = new Font("Arial", 10, FontStyle.Underline);
            label4.Font = new Font("Arial", 10, FontStyle.Underline);

            label1.Font = new Font("Arial", 9, FontStyle.Regular);
            label2.Font = new Font("Arial", 9, FontStyle.Regular);
            label3.Font = new Font("Arial", 9, FontStyle.Regular);
            
            label7.Visible=false;
            roditelj =r;
         /*   if (r.isServerDown)
            {
                MessageBox.Show("Server je ugašen. Molimo vas ponovo se prijavite.");
                this.Visible = false;
                // Otvaranje forme za prijavljivanje
                Login loginForm = new Login();
                loginForm.Show();
                return;
            }
            Response odgovor = (Response)*/
                cmbDeca.DataSource = ChangeDataChildGUIController.Instance.GetChildren(roditelj);
            /*  if (odgovor==null)
              {
                 this.Close();
                  // Otvaranje forme za prijavljivanje

                  Login loginForm = new Login();
                  loginForm.Show();
                  return;
              }*/
            label6.Visible = false;
            cmbDeca.DisplayMember = "ImePrezime";
            cmbDeca.SelectedIndex = -1;
            txtIme.Text = "";
            txtDatum.Text = "";
            txtPrezime.Text = "";
        }



        private void btnPromeni_Click(object sender, EventArgs e)
        {
            Dete deteid = (Dete)cmbDeca.SelectedItem;

            if (cmbDeca.SelectedItem!=null)
            {

                label6.Visible = true;
                label6.Text = "Sistem je ucitao podatke o detetu!";
                Dete dete = new Dete();
                dete.ime = txtIme.Text;
                dete.prezime = txtPrezime.Text;
                dete.clanstvo = true;
                dete.roditelj = roditelj;
                dete.id = deteid.id;
                var s = txtDatum.Text;
                bool isCorrectB = false;
                bool isCorrectR = false;
                DateTime datum;
                if (DateTime.TryParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum) && datum < DateTime.Now)
                {
                    dete.datumRodjenja = datum;
                    isCorrectB = true;
                }
                else
                {
                    if (datum > DateTime.Now)
                    {
                        MessageBox.Show("Nije dozvoljen unos datuma koji je u buducnosti!");
                        isCorrectB = false;
                    }
                    else
                    {
                        MessageBox.Show("Datum nije unet u dobrom formatu! Format je dd/MM/YYYY");
                        isCorrectB = false;
                    }
                }
                /* try
                 {
                     dete.datumRodjenja = DateTime.ParseExact(txtDatum.Text, "dd/MM/YYYY", CultureInfo.InvariantCulture);
                 }
                 catch (FormatException)
                 {
                     MessageBox.Show("Datum nije unet u dobrom formatu! Format je dd//MM/YYYY");

                 }*/

                if (txtIme.Text == "" || txtPrezime.Text == "" || txtDatum.Text == "")
                {
                    MessageBox.Show("Sistem ne moze da zapamti podatke o detetu!");
                    MessageBox.Show("Niste popunili sva polja");
                    isCorrectR = false;
                }
                else
                {
                    isCorrectR = true;
                }

                if (isCorrectR == true && isCorrectB == true)
                {
                    ChangeDataChildGUIController.Instance.Change(dete);

                }
            }
            else
            {
                MessageBox.Show("Niste selektovali dete kome zelite da promenite podatke!");
                label6.Text = "Sistem ne moze da ucita podatke o detetu!";
                label6.Visible = true;
            }

        }

        private void cmbDeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if (cmbDeca.SelectedItem != null &&  cmbDeca.SelectedIndex!=-1)
            {
              Dete selectedDete = (Dete)cmbDeca.SelectedItem;

              txtIme.Text = selectedDete.ime;
              txtPrezime.Text = selectedDete.prezime;
              txtDatum.Text = selectedDete.datumRodjenja.ToString("yyyy-MM-dd");
                label6.Visible=true;
                label6.Text = "Sistem je ucitao podatke o detetu!";
           }
            
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
