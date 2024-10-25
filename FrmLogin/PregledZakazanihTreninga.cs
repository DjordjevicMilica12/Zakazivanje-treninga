using Common;
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
    public partial class PregledZakazanihTreninga : Form
    {
     
        public PregledZakazanihTreninga(Common.Communication.Response r, Uloge uloga)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(249, 231, 249);
            label1.Font = new Font("Arial", 10, FontStyle.Underline);
            label1.Text = "Na ovoj stranici su prikazani svi zakazani treninzi";

            if (uloga == Uloge.roditelj)
            {
                List<Roditelj> roditelji = (List<Roditelj>)r.Result;
                Roditelj roditelj = roditelji[0];
                dgvZakazaniTreninzi.DataSource= DecaZakazaniTreninziGUIController.Instance.zakazaniTreninziDeca(roditelj);

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
            else
            {
                List<Trener> treneri = (List<Trener>)r.Result;
                Trener t = treneri[0];
                Termin termin = new Termin();
                termin.trener = t;
                dgvZakazaniTreninzi.DataSource = ZakazaniTreninziGUIController.Instance.zakazaniTreninzi(termin);
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
        }
    }
}
