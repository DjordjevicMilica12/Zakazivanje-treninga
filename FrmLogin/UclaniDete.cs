using Common;
using Common.Communication;
using Common.Domain;
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

namespace FrmLogin
{
    public partial class UclaniDete : Form
    {
        Roditelj roditelj;
        private Response r;

        public UclaniDete(Roditelj r)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(249, 231, 249);
            label4.Font = new Font("Arial", 10, FontStyle.Underline);
            label2.Font = new Font("Arial", 9, FontStyle.Regular);
            label1.Font = new Font("Arial", 9, FontStyle.Regular);
            label3.Font = new Font("Arial", 9, FontStyle.Regular);
            txtIme.Text = "Ana";
            txtPrezime.Text = "Zekovic";
            txtDatum.Text = "1997-01-01";
            roditelj = r;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dete dete = new Dete();
            dete.ime = txtIme.Text;
            dete.prezime = txtPrezime.Text;
            dete.clanstvo = true;
            dete.roditelj = roditelj;

            var s = txtDatum.Text;
            bool isCorrectD = false;
            bool isCorrectR = false;

            DateTime datum;
            if (DateTime.TryParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum) && datum<DateTime.Now)
            {         
                dete.datumRodjenja = datum;     
                isCorrectD = true;
            }
            else
            {
                if (datum > DateTime.Now)
                {
                    MessageBox.Show("Nije dozvoljen unos datuma koji je u buducnosti!");
                    isCorrectD = false;
                }
                else
                {
                MessageBox.Show("Datum nije unet u dobrom formatu! Format je YYYY/MM/dd");
                isCorrectD = false;

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
                MessageBox.Show("Sistem ne moze da zapamti dete!");
                MessageBox.Show("Niste popunili sve podatke");
                isCorrectR = false;
            }
            else
            {
                isCorrectR = true;
            }

            if (isCorrectD == true && isCorrectR==true)
            {
             AddGUIController.Instance.Add(dete);
            
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
