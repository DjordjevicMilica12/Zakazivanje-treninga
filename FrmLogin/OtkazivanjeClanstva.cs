using Common;
using Common.Communication;
using Common.Domain;
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
    public partial class OtkazivanjeClanstva : Form
    {
        Roditelj roditelj;
        public OtkazivanjeClanstva(Roditelj r)
        {
            InitializeComponent();
            roditelj = r;
            cmbDeca.DataSource= ChangeDataChildGUIController.Instance.GetChildren(roditelj);
            cmbDeca.DisplayMember = "ImePrezime";
            cmbDeca.SelectedIndex = -1;
            this.BackColor = Color.FromArgb(249, 231, 249);
            label1.Font = new Font("Arial", 9, FontStyle.Regular);
            label2.Visible= false;
        }

        private void btnOtkaziClanstvo_Click(object sender, EventArgs e)
        {

            bool otkaziClanstvo = true;

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete članstvo?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cmbDeca.SelectedIndex != -1)
            {

            List<Termin> otkazDete= DecaZakazaniTreninziGUIController.Instance.zakazaniTreninziDeca(roditelj);
                    Dete dete = (Dete)cmbDeca.SelectedItem;
               
                foreach(Termin t in otkazDete)
                {
                    if (t.planTreninga.dete.ime ==dete.ime && t.planTreninga.dete.prezime == dete.prezime)
                    {
                        MessageBox.Show("Morate prvo otkazati treninge za " + dete.ime + " " + dete.prezime);
                         otkaziClanstvo= false;
                   /*     DialogResult res = MessageBox.Show("Imate zakazane treninge za "+dete.ime +" "+dete.prezime+ " Da li ste sigurni da želite da otkažete članstvo?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            OtkaziTreningGUIController.Instance.otkaziTreningRoditelj(t);
                        }
                        otkaziClanstvo = false;*/
                    }
                }

                if (result == DialogResult.Yes && otkaziClanstvo==true)
                {
                    DeleteChild.Instance.deleteChild(dete);
                    //OtkaziClanstvo()
                }
            }
            else
            {
                MessageBox.Show("Sistem ne moze da ucita dete");
                MessageBox.Show("Morate izabrati dete");
            //    MessageBox.Show("Sistem ne moze otkazati clanstvo");
            }
        }

       /* private void OtkaziClanstvo()
        {
            Dete dete = (Dete)cmbDeca.SelectedItem;
            DeleteChild.Instance.deleteChild(dete);
        }*/

        private void cmbDeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeca.SelectedItem != null && cmbDeca.SelectedIndex!=-1)
            {
                Dete selectedChild = (Dete)cmbDeca.SelectedItem;
                label2.Text = "Sistem je ucitao " + selectedChild.ime + " " + selectedChild.prezime;
                label2.Visible = true;
            }
            
        }
    }
}
