namespace FrmLogin
{
    partial class UbaciVezbu
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
            this.txtVezba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvZakazaniTreninzi = new System.Windows.Forms.DataGridView();
            this.btnPregledVezbi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upisite vezbu:";
            // 
            // txtVezba
            // 
            this.txtVezba.Location = new System.Drawing.Point(32, 54);
            this.txtVezba.Name = "txtVezba";
            this.txtVezba.Size = new System.Drawing.Size(262, 22);
            this.txtVezba.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ubaci Vezbu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvZakazaniTreninzi
            // 
            this.dgvZakazaniTreninzi.AllowUserToAddRows = false;
            this.dgvZakazaniTreninzi.AllowUserToDeleteRows = false;
            this.dgvZakazaniTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZakazaniTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakazaniTreninzi.Location = new System.Drawing.Point(32, 106);
            this.dgvZakazaniTreninzi.Name = "dgvZakazaniTreninzi";
            this.dgvZakazaniTreninzi.ReadOnly = true;
            this.dgvZakazaniTreninzi.RowHeadersWidth = 51;
            this.dgvZakazaniTreninzi.RowTemplate.Height = 24;
            this.dgvZakazaniTreninzi.Size = new System.Drawing.Size(579, 182);
            this.dgvZakazaniTreninzi.TabIndex = 5;
            this.dgvZakazaniTreninzi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZakazaniTreninzi_CellClick);
            // 
            // btnPregledVezbi
            // 
            this.btnPregledVezbi.Location = new System.Drawing.Point(132, 315);
            this.btnPregledVezbi.Name = "btnPregledVezbi";
            this.btnPregledVezbi.Size = new System.Drawing.Size(103, 33);
            this.btnPregledVezbi.TabIndex = 6;
            this.btnPregledVezbi.Text = "Pregled vezbi";
            this.btnPregledVezbi.UseVisualStyleBackColor = true;
            this.btnPregledVezbi.Click += new System.EventHandler(this.btnPregledVezbi_Click);
            // 
            // UbaciVezbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 410);
            this.Controls.Add(this.btnPregledVezbi);
            this.Controls.Add(this.dgvZakazaniTreninzi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVezba);
            this.Controls.Add(this.label1);
            this.Name = "UbaciVezbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbaciVezbu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVezba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvZakazaniTreninzi;
        private System.Windows.Forms.Button btnPregledVezbi;
    }
}