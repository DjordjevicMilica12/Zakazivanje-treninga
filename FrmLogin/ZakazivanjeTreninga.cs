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
    public partial class ZakazivanjeTreninga : Form
    {
        Roditelj roditelj;
        public ZakazivanjeTreninga(Roditelj r)
        {
            InitializeComponent();
            roditelj = r;
            this.BackColor = Color.FromArgb(249, 231, 249);
            label1.Font = new Font("Arial", 10, FontStyle.Underline);
            label2.Font = new Font("Arial", 9, FontStyle.Underline);
            label3.Font = new Font("Arial", 9, FontStyle.Underline);

            Init();
            
        }

        private void Init()
        {

            cmbDeca.DataSource = ChangeDataChildGUIController.Instance.GetChildren(roditelj);
            cmbDeca.DisplayMember = "ImePrezime";
            cmbDeca.SelectedIndex = -1;


            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            List<Termin> termini= ZakaziTreningGUIController.Instance.DajTermin();
            List<Common.Domain.Program> programi = ZakaziTreningGUIController.Instance.DajProgram();

                 dgvTermini.DataSource = termini;
                 dgvProgrami.DataSource = programi;

            dgvTermini.AutoGenerateColumns = false;
            dgvProgrami.AutoGenerateColumns = false;

            dgvProgrami.Columns.Remove("sifraPrograma");
            dgvProgrami.Columns.Remove("UpdateCondition");
            dgvProgrami.Columns.Remove("UpdateValues");
            dgvProgrami.Columns.Remove("JoinCondition");
            dgvProgrami.Columns.Remove("JoinValues");
            dgvProgrami.Columns.Remove("Values");
            dgvProgrami.Columns.Remove("TableName");

            dgvTermini.Columns.Remove("slobodan");
                 dgvTermini.Columns.Remove("Trener");
                 dgvTermini.Columns.Remove("id");
                 dgvTermini.Columns.Remove("planTreninga");

            dgvTermini.Columns.Remove("UpdateCondition");
            dgvTermini.Columns.Remove("UpdateValues");
            dgvTermini.Columns.Remove("JoinCondition");
            dgvTermini.Columns.Remove("JoinValues");
            dgvTermini.Columns.Remove("Values");
            dgvTermini.Columns.Remove("TableName");
            dgvTermini.Columns.Remove("vrednost");

            dgvTermini.Columns.Remove("ImeDete");
                dgvTermini.Columns.Remove("PrezimeDete");
                dgvTermini.Columns.Remove("NazivPrograma");
               


            #region
            //   row.Cells["opisColumn"].Value = termin.planTreninga.opis;
            //  row.Cells["ciljColumn"].Value = termin.planTreninga.cilj;

            //     DataGridViewTextBoxColumn datumIVremeColumn = new DataGridViewTextBoxColumn();
            //     datumIVremeColumn.HeaderText = "Datum i Vreme";
            //     datumIVremeColumn.DataPropertyName = "datumIVreme";

            /*     DataGridViewTextBoxColumn opisColumn = new DataGridViewTextBoxColumn();
                 opisColumn.HeaderText = "Opis";
                 opisColumn.Name = "opisColumn";

            DataGridViewTextBoxColumn ciljColumn = new DataGridViewTextBoxColumn();
                 ciljColumn.HeaderText = "Cilj";
                 ciljColumn.Name = "ciljColumn";

                 dgvTermini.Columns.Add(datumIVremeColumn);
                 dgvTermini.Columns.Add(opisColumn);
                 dgvTermini.Columns.Add(ciljColumn);*/

            //    dgvTermini.CellFormatting += DgvTermini_CellFormatting;
            #endregion

        }

        /*   private void DgvTermini_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
           {
               if (e.ColumnIndex == dgvTermini.Columns["opisColumn"].Index && e.RowIndex >= 0)
               {
                   var termin = dgvTermini.Rows[e.RowIndex].DataBoundItem as Termin;
                   if (termin != null)
                   {
                       e.Value = termin.planTreninga.opis;
                   }
               }
               else if (e.ColumnIndex == dgvTermini.Columns["ciljColumn"].Index && e.RowIndex >= 0)
               {
                   var termin = dgvTermini.Rows[e.RowIndex].DataBoundItem as Termin;
                   if (termin != null)
                   {
                       e.Value = termin.planTreninga.cilj;
                   }
               }
           }*/

        private void btnZakaziTrening_Click(object sender, EventArgs e)
        {
            Dete dete= cmbDeca.SelectedItem as Dete;

            if (selectedtermin.datumIVreme == default)
            {
                //MessageBox.Show("Morate izabrati termin!");
                MessageBox.Show("Sistem nije ucitao slobodan termin treninga!");
            }
            else if(dete == null){
               // MessageBox.Show("Morate izabrati dete!");
                MessageBox.Show("Sistem nije ucitao dete!");
            }
            else if (selectedProgram.nazivPrograma == null)
            {
                   MessageBox.Show("Sistem nije zakazao trening!!");
            
            }
            else
            {
                selectedtermin.planTreninga = new PlanTreninga();
                selectedtermin.planTreninga.id = ZakaziTreningGUIController.Instance.vratiID()+1;
                selectedtermin.planTreninga.dete = dete;
                selectedtermin.planTreninga.program = selectedProgram;
                ZakaziTreningGUIController.Instance.ZakaziTrening(selectedtermin);
            }


        }

       private Termin selectedtermin=new Termin();
        private void dgvTermini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.RowIndex==default)
            {

                selectedtermin = (Termin)dgvTermini.Rows[e.RowIndex].DataBoundItem;
            label4.Text="Sistem je ucitao termin "+selectedtermin.datumIVreme.ToString();
            label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Morate izabrati neku celiju!");
            }
       
        }

        private Common.Domain.Program selectedProgram = new Common.Domain.Program();
        private void dgvProgrami_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0)
                {

                    selectedProgram = (Common.Domain.Program)dgvProgrami.Rows[e.RowIndex].DataBoundItem;
                label5.Text = "Sistem je ucitao program " + selectedProgram.nazivPrograma.ToString();
                label5.Visible = true;
            }
            else
            {
                MessageBox.Show("Morate izabrati neku celiju!");
            }
           
           
           
        }

        private void cmbDeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeca.SelectedItem != null && cmbDeca.SelectedIndex!=-1)
            {
                Dete selectedChild = (Dete)cmbDeca.SelectedItem;
                label6.Text="Sistem je ucitao dete " + selectedChild.ime+" "+ selectedChild.prezime;
                label6.Visible = true;
            }
           
        }

    
    }
}
