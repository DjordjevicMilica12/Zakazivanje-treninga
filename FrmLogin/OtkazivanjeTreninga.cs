using Common;
using Common.Communication;
using Common.Domain;
using FrmLogin.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class OtkazivanjeTreninga : Form
    {
        Uloge uloge= new Uloge();
        Trener t=new Trener();
        public OtkazivanjeTreninga(Common.Communication.Response r, Uloge u)
        {
            InitializeComponent();
            if (u == Uloge.trener)
            {
            uloge = u;
                List<Trener> treneri = (List<Trener>)r.Result;
                t= treneri[0];
                Termin termin=new Termin();
                termin.trener = t;
                dgvTreninzi.DataSource = ZakazaniTreninziGUIController.Instance.zakazaniTreninzi(termin);
                dgvTreninzi.AutoGenerateColumns = false;

                dgvTreninzi.AutoGenerateColumns = false;
                dgvTreninzi.Columns.Remove("id");
                dgvTreninzi.Columns.Remove("trener");
                dgvTreninzi.Columns.Remove("slobodan");
                dgvTreninzi.Columns.Remove("planTreninga");
                dgvTreninzi.Columns.Remove("UpdateCondition");
                dgvTreninzi.Columns.Remove("UpdateValues");
                dgvTreninzi.Columns.Remove("JoinCondition");
                dgvTreninzi.Columns.Remove("JoinValues");
                dgvTreninzi.Columns.Remove("Values");
                dgvTreninzi.Columns.Remove("TableName");
                dgvTreninzi.Columns.Remove("vrednost");


                dgvTreninzi.Columns["datumIVreme"].HeaderText = "Datum i vreme";
                dgvTreninzi.Columns["ImeDete"].HeaderText = "Ime";
                dgvTreninzi.Columns["PrezimeDete"].HeaderText = "Prezime";
                dgvTreninzi.Columns["NazivPrograma"].HeaderText = "Naziv programa";
                this.BackColor = Color.FromArgb(249, 231, 249);
                label1.Font = new Font("Arial", 10, FontStyle.Underline);
            }
            else
            {

                List<Roditelj> roditelji = (List<Roditelj>)r.Result;
                Roditelj roditelj = roditelji[0];
                //Roditelj roditelj = (Roditelj)r.Result;
                dgvTreninzi.DataSource = DecaZakazaniTreninziGUIController.Instance.zakazaniTreninziDeca(roditelj); 
                this.BackColor = Color.FromArgb(249, 231, 249);
                label1.Font = new Font("Arial", 10, FontStyle.Underline);
                 dgvTreninzi.AutoGenerateColumns = false;

                dgvTreninzi.AutoGenerateColumns = false;
                dgvTreninzi.Columns.Remove("id");
                dgvTreninzi.Columns.Remove("trener");
                dgvTreninzi.Columns.Remove("slobodan");
                dgvTreninzi.Columns.Remove("planTreninga");
                dgvTreninzi.Columns.Remove("UpdateCondition");
                dgvTreninzi.Columns.Remove("UpdateValues");
                dgvTreninzi.Columns.Remove("JoinCondition");
                dgvTreninzi.Columns.Remove("JoinValues");
                dgvTreninzi.Columns.Remove("Values");
                dgvTreninzi.Columns.Remove("TableName");
                dgvTreninzi.Columns.Remove("vrednost");


                dgvTreninzi.Columns["datumIVreme"].HeaderText = "Datum i vreme";
                dgvTreninzi.Columns["ImeDete"].HeaderText = "Ime";
                dgvTreninzi.Columns["PrezimeDete"].HeaderText = "Prezime";
                dgvTreninzi.Columns["NazivPrograma"].HeaderText = "Naziv programa";

            }
        }

        private void btnOtkaziTrening_Click(object sender, EventArgs e)
        {
            if (uloge == Uloge.trener)
            {
           
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete odabrani trening?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
             
                    if (termin.datumIVreme != default)
                    {
                        termin.trener = t;
                        OtkaziTreningGUIController.Instance.otkaziTrening(termin);
                    }
                    else
                    {
                        MessageBox.Show("Niste odabrali trening za otkazivanje. Molimo vas da odaberete trening iz tabele.");
                     
                    }
                }
                    else
                    {
               
                        MessageBox.Show("Otkazivanje treninga je otkazano.");
                    }
            }
            else
            {


                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete odabrani trening?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (termin.datumIVreme != default)
                    {
                        // OtkaziTreningGUIController.Instance.otkaziTreningRoditelj(termin);
                        termin.trener = null;
                        OtkaziTreningGUIController.Instance.otkaziTrening(termin);
                    }
                    else
                    {
                        MessageBox.Show("Niste odabrali trening za otkazivanje. Molimo vas da odaberete trening iz tabele.");
                       
                    }
                }
                else
                {

                     MessageBox.Show("Otkazivanje treninga je otkazano.");
                   // MessageBox.Show("Sistem ne moze da otkaze trening.");
                }






            }
        }

        private Termin termin = new Termin();

        private void dgvTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                termin = (Termin)dgvTreninzi.Rows[e.RowIndex].DataBoundItem;
                 MessageBox.Show("Sistem je ucitao trening za " +termin.planTreninga.dete.ime + " "+ termin.planTreninga.dete.prezime + " "+termin.planTreninga.program.nazivPrograma + " "+termin.datumIVreme);
              
            }
            else
            {
                MessageBox.Show("Morate izabrati neku celiju!");
             //   MessageBox.Show("Sistem ne moze da ucita rezervisan termin treninga");
            }
        }
    }
    }
