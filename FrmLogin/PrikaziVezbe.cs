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
    public partial class PrikaziVezbe : Form
    {
        public PrikaziVezbe(Termin t)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(249, 231, 249);
            label1.Font = new Font("Arial", 12, FontStyle.Regular);
            dgvVezbe.DataSource=PrikaziVezbuGUIController.Instance.PrikaziVezbe(t);
            if (dgvVezbe.DataSource != null)
            {
            dgvVezbe.AutoGenerateColumns = false;
            dgvVezbe.Columns.Remove("id");
            dgvVezbe.Columns.Remove("planTreninga");
            dgvVezbe.Columns.Remove("TableName");
            dgvVezbe.Columns.Remove("Values");
            dgvVezbe.Columns.Remove("JoinValues");
            dgvVezbe.Columns.Remove("JoinCondition");
            dgvVezbe.Columns.Remove("UpdateValues");
            dgvVezbe.Columns.Remove("UpdateCondition");
            }
           
           
        }
    }
}
