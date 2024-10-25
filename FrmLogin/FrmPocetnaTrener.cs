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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public enum Izbor
    {
        brisanje,
        unos
    }
    public enum Uloge
    {
        roditelj, 
        trener,
    }
   
    public partial class FrmPocetnaTrener : Form
    {
        Response r;
        Trener trenerGlavni;
        public FrmPocetnaTrener(Response response)
        {
            InitializeComponent();
            List<Trener> treneri = (List<Trener>)response.Result;
            trenerGlavni = treneri[0];
            lblDobrodosli.Text = "Dobro dosli treneru " + treneri[0].ime+" " + treneri[0].prezime + " :)";
            r = response;
            lbltext.Text = "U gornjem meniju mozete izabrati koju operaciju zelite da izvrsite! ";
           // Trener t = (Trener)r.Result;
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Arial", 9, FontStyle.Bold);
            this.BackColor = Color.FromArgb(249, 231, 249);
            
            lblDobrodosli.Font=new Font("Arial", 13, FontStyle.Italic);
            lbltext.Font = new Font("Arial", 11, FontStyle.Italic);

            lblMotivacioniCitat.Text = "„Najteža stvar kod vežbanja је započeti. Jednom kada vežbas redovno,\n najteža stvar je prestati.“ – Erin Gray";
            lblMotivacioniCitat.Font = new Font("Arial", 9, FontStyle.Italic);

        }



        private void unosSlobodnogTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UnosSLobodnogTermina u = new UnosSLobodnogTermina(trenerGlavni, Izbor.unos);
            u.FormClosed += (s, args) => this.Show();
            u.Show();
        }

        private void brisanjeTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UnosSLobodnogTermina u = new UnosSLobodnogTermina(trenerGlavni, Izbor.brisanje);
            u.FormClosed += (s, args) => this.Show();
            u.Show();
        }

        private void otkazivanjeTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OtkazivanjeTreninga otkazivanje = new OtkazivanjeTreninga(r,Uloge.trener);
            otkazivanje.FormClosed += (s, args) => this.Show();
            otkazivanje.Show();
        }

        private void ubaciVezbuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;   
            UbaciVezbu u = new UbaciVezbu(trenerGlavni);
            u.FormClosed += (s, args) => this.Show();
            u.Show();
        }

        private void pregledZakazanihTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PregledZakazanihTreninga pz = new PregledZakazanihTreninga(r, Uloge.trener);
            pz.FormClosed += (s, args) => this.Show();
            pz.Show();
        }
    }
}
