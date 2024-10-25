using Common;
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
using System.Xml;

namespace FrmLogin
{
    public partial class FrmPocetnaRoditelj : Form
    {
        Response r;
        Roditelj roditeljGlavni;
        public FrmPocetnaRoditelj(Response response)
        {
            InitializeComponent();
            List<Roditelj> roditelji = (List<Roditelj>)response.Result;

            roditeljGlavni = roditelji[0];
            lblDobrodosli.Text="Dobro dosli " + roditelji[0].ime + " " +roditelji[0].prezime + " :)";
            r= response;

            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Arial", 7, FontStyle.Bold);
            this.BackColor = Color.FromArgb(249, 231, 249);
            lblText.Text = "U gornjem meniju mozete izabrati koju operaciju zelite da izvrsite! ";
            lblDobrodosli.Font = new Font("Arial", 13, FontStyle.Italic);
            lblText.Font = new Font("Arial", 11, FontStyle.Italic);
           

            lblMotivacioniCitat.Text="„Najteža stvar kod vežbanja је započeti. Jednom kada vežbas redovno,\n najteža stvar je prestati.“ – Erin Gray";
            lblMotivacioniCitat.Font = new Font("Arial", 9, FontStyle.Italic);

        }

        private void uclaniteDeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            UclaniDete uclaniDete = new UclaniDete(roditeljGlavni);
            uclaniDete.FormClosed += (s, args) => this.Show();
            uclaniDete.Show();
        }

        private void promenaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            PromeniPodatkeDetetu ppd = new PromeniPodatkeDetetu(roditeljGlavni);
            ppd.FormClosed += (s, args) => this.Show();
            ppd.Show();
        }

        private void otkazivanjeClanstvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OtkazivanjeClanstva otkaz = new OtkazivanjeClanstva(roditeljGlavni);
            otkaz.FormClosed += (s, args) => this.Show();
            otkaz.Show();
        }

        private void zakazivanjeTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ZakazivanjeTreninga otkaz = new ZakazivanjeTreninga(roditeljGlavni);
            otkaz.FormClosed += (s, args) => this.Show();
            otkaz.Show();
        }

        private void otkaziTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OtkazivanjeTreninga o = new OtkazivanjeTreninga(r, Uloge.roditelj);
            o.FormClosed += (s, args) => this.Show();
            o.Show();
        }

        private void pregledZakazanihTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            PregledZakazanihTreninga pz=new PregledZakazanihTreninga(r, Uloge.roditelj);
            pz.FormClosed += (s, args) => this.Show();
            pz.Show();
        }
    }
}
