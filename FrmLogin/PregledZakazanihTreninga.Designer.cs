namespace FrmLogin
{
    partial class PregledZakazanihTreninga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZakazaniTreninzi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dgvZakazaniTreninzi
            // 
            this.dgvZakazaniTreninzi.AllowUserToAddRows = false;
            this.dgvZakazaniTreninzi.AllowUserToDeleteRows = false;
            this.dgvZakazaniTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZakazaniTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakazaniTreninzi.Location = new System.Drawing.Point(40, 80);
            this.dgvZakazaniTreninzi.Name = "dgvZakazaniTreninzi";
            this.dgvZakazaniTreninzi.ReadOnly = true;
            this.dgvZakazaniTreninzi.RowHeadersWidth = 51;
            this.dgvZakazaniTreninzi.RowTemplate.Height = 24;
            this.dgvZakazaniTreninzi.Size = new System.Drawing.Size(609, 194);
            this.dgvZakazaniTreninzi.TabIndex = 1;
            // 
            // PregledZakazanihTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 349);
            this.Controls.Add(this.dgvZakazaniTreninzi);
            this.Controls.Add(this.label1);
            this.Name = "PregledZakazanihTreninga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledZakazanihTreninga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZakazaniTreninzi;
    }
}