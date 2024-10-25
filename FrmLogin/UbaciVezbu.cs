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
    public partial class UbaciVezbu : Form
    {
        public UbaciVezbu(Trener r)
        {
            InitializeComponent();
            Trener t = r;
            this.BackColor = Color.FromArgb(249, 231, 249);
            label1.Font = new Font("Arial", 10, FontStyle.Underline);
            Termin termin = new Termin();
            termin.trener = t;
            dgvZakazaniTreninzi.DataSource= ZakazaniTreninziGUIController.Instance.zakazaniTreninzi(termin);
            dgvZakazaniTreninzi.AutoGenerateColumns = false;

            dgvZakazaniTreninzi.AutoGenerateColumns = false;
            dgvZakazaniTreninzi.Columns.Remove("id");
            dgvZakazaniTreninzi.Columns.Remove("trener");
            dgvZakazaniTreninzi.Columns.Remove("slobodan");
            dgvZakazaniTreninzi.Columns.Remove("planTreninga");
            dgvZakazaniTreninzi.Columns.Remove("UpdateCondition");
            dgvZakazaniTreninzi.Columns.Remove("UpdateValues");
            dgvZakazaniTreninzi.Columns.Remove("JoinCondition");
            dgvZakazaniTreninzi.Columns.Remove("JoinValues");
            dgvZakazaniTreninzi.Columns.Remove("Values");
            dgvZakazaniTreninzi.Columns.Remove("TableName");
            dgvZakazaniTreninzi.Columns.Remove("vrednost");
           

            dgvZakazaniTreninzi.Columns["datumIVreme"].HeaderText = "Datum i vreme";
            dgvZakazaniTreninzi.Columns["ImeDete"].HeaderText = "Ime";
            dgvZakazaniTreninzi.Columns["PrezimeDete"].HeaderText = "Prezime";
            dgvZakazaniTreninzi.Columns["NazivPrograma"].HeaderText = "Naziv programa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtVezba.Text))
            {
                MessageBox.Show("morate popuniti tekstualno polje za nazivom vezbi!");
            }
            else if(termin.datumIVreme==default)
            {
                MessageBox.Show("Oznacite za koga zelite da unesete vezbu!");
            }
            else
            {
                Vezbe vezbe = new Vezbe();
                vezbe.nazivVezbe = txtVezba.Text;
                vezbe.planTreninga=new PlanTreninga();
                vezbe.planTreninga.id = termin.planTreninga.id;
                UbaciVezbuGUIController.Instance.UbaciVezbu(vezbe);

            }
        }

        Termin termin= new Termin();    
        private void dgvZakazaniTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                termin = (Common.Domain.Termin)dgvZakazaniTreninzi.Rows[e.RowIndex].DataBoundItem;
                // MessageBox.Show("Sistem je ucitao termin "+termin.datumIVreme + " za "+termin.planTreninga.dete.ime+ " "+termin.planTreninga.dete.prezime+" " + termin.planTreninga.program.nazivPrograma);
                //ovo stavi kada budes ubacila i naziv treninga!
                MessageBox.Show("Sistem je ucitao termin " + termin.datumIVreme + " za " + termin.planTreninga.dete.ime + " " + termin.planTreninga.dete.prezime);
            }
            else
            {
                 MessageBox.Show("Morate izabrati neku celiju!");  
                //MessageBox.Show("Sistem nije ucitao termin treninga!");
                //MessageBox.Show("Sistem nije ubacio vezbu!");
            }
        }

        private void btnPregledVezbi_Click(object sender, EventArgs e)
        {
            if (termin.datumIVreme == default)
            {
                MessageBox.Show("Morate oznaciti za koga zelite da pogledate vezbe");
            }
            else
            {
                this.Visible = false;
                PrikaziVezbe o = new PrikaziVezbe(termin);
                o.FormClosed += (s, args) => this.Show();
                o.Show();
            
            }
        }
    }
}
