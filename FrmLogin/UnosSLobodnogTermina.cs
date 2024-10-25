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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class UnosSLobodnogTermina : Form
    {
        Trener trener;
        public UnosSLobodnogTermina(Trener r, Izbor i)
        {
            InitializeComponent();
       
            trener = r;
            if (i==Izbor.brisanje)
            {
                lblUnos.Visible = false;
                txtDatum.Visible = false;
                btnUnos.Visible = false; 
                
                lblObrisi.Visible = true;
                btnObrisi.Visible = true;
                cmbDatumi.Visible = true;

             

                cmbDatumi.DataSource = DeleteDataGUIControllercs.Instance.GetDate(trener); //uradjeno
                cmbDatumi.DisplayMember = "datumIVreme";


                cmbDatumi.SelectedIndex = -1;
                label1.Visible = false;

                this.BackColor = Color.FromArgb(249, 231, 249);
                lblObrisi.Font = new Font("Arial", 9, FontStyle.Underline);

            }
            if (i == Izbor.unos)
            {
                lblUnos.Visible = true;
                txtDatum.Visible = true;
                btnUnos.Visible = true;

                label1.Visible = false;
                lblObrisi.Visible = false;
                btnObrisi.Visible = false;
                cmbDatumi.Visible = false;
                this.BackColor = Color.FromArgb(249, 231, 249);
                lblUnos.Font = new Font("Arial", 9, FontStyle.Underline);
            }

        }

            private void btnUnos_Click(object sender, EventArgs e)
            {
                DateTime datum;
                if (string.IsNullOrWhiteSpace(txtDatum.Text))
                {
                 MessageBox.Show("Morate uneti datum!");
               // MessageBox.Show("Sistem ne moze da zapamti slobodan termin!");
            }
                else if (DateTime.TryParseExact(txtDatum.Text, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum) && datum > DateTime.Now)
                {
                    Termin t= new Termin();
                    t.datumIVreme= datum;
                    t.trener= trener;
                    bool odgovor= AddDateGUIController.Instance.DaLiPostojiDatum(t); //uradjeno
                    if (odgovor == true)
                      {
                             MessageBox.Show("datum vec postoji u bazi");
                      }
                    else
                      {
                        AddDateGUIController.Instance.AddDate(t); //uradjeno
                      }
                }
                 else
                {
                    if ( datum < DateTime.Now && datum!=default)
                    {
                        MessageBox.Show("Uneli ste datum koji je u proslosti");
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste neispravan format datuma. Ispravan format je yyyy-MM-dd hh:mm");

                    }
                }
            }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(termin2 == null)
            {
                 MessageBox.Show("Niste oznacili datum");
                // MessageBox.Show("Sistem ne moze da ucita termin");
               //  MessageBox.Show("Sistem ne moze da obrise termin");
            }
            else
            {
                Termin t = new Termin();
                if (DateTime.TryParse(termin2.datumIVreme.ToString() , out DateTime datum))
                {
                    t.datumIVreme = datum;
                    DeleteDatumGUIController.Instance.DeleteDatum(t);
                }
                else
                {
                   // MessageBox.Show("Neuspešno parsiranje datuma.");
                    MessageBox.Show("Niste oznacili datum"+ cmbDatumi.SelectedItem.ToString());
                }
            }
        }

        Termin termin2 = null;

        private void cmbDatumi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatumi.SelectedItem != null && cmbDatumi.SelectedIndex!=-1)
            {
                 termin2 = (Termin)cmbDatumi.SelectedItem;
                label1.Text = "Sistem je ucitao termin " +termin2.datumIVreme;

                label1.Visible = true;
            }
        }
    }
}
