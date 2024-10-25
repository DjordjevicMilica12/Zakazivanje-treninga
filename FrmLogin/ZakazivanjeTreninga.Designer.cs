namespace FrmLogin
{
    partial class ZakazivanjeTreninga
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
            this.cmbDeca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnZakaziTrening = new System.Windows.Forms.Button();
            this.dgvProgrami = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrami)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDeca
            // 
            this.cmbDeca.FormattingEnabled = true;
            this.cmbDeca.Location = new System.Drawing.Point(49, 65);
            this.cmbDeca.Name = "cmbDeca";
            this.cmbDeca.Size = new System.Drawing.Size(194, 24);
            this.cmbDeca.TabIndex = 0;
            this.cmbDeca.SelectedIndexChanged += new System.EventHandler(this.cmbDeca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izberite dete za koje zelite da zakazete trening";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Slobodni termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(49, 147);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(222, 173);
            this.dgvTermini.TabIndex = 3;
            this.dgvTermini.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellClick);
           
            // 
            // btnZakaziTrening
            // 
            this.btnZakaziTrening.Location = new System.Drawing.Point(576, 364);
            this.btnZakaziTrening.Name = "btnZakaziTrening";
            this.btnZakaziTrening.Size = new System.Drawing.Size(144, 37);
            this.btnZakaziTrening.TabIndex = 4;
            this.btnZakaziTrening.Text = "Zakazi trening";
            this.btnZakaziTrening.UseVisualStyleBackColor = true;
            this.btnZakaziTrening.Click += new System.EventHandler(this.btnZakaziTrening_Click);
            // 
            // dgvProgrami
            // 
            this.dgvProgrami.AllowUserToAddRows = false;
            this.dgvProgrami.AllowUserToDeleteRows = false;
            this.dgvProgrami.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgrami.Location = new System.Drawing.Point(311, 147);
            this.dgvProgrami.MultiSelect = false;
            this.dgvProgrami.Name = "dgvProgrami";
            this.dgvProgrami.ReadOnly = true;
            this.dgvProgrami.RowHeadersWidth = 51;
            this.dgvProgrami.RowTemplate.Height = 24;
            this.dgvProgrami.Size = new System.Drawing.Size(421, 173);
            this.dgvProgrami.TabIndex = 5;
            this.dgvProgrami.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgrami_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Programi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // ZakazivanjeTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProgrami);
            this.Controls.Add(this.btnZakaziTrening);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeca);
            this.Name = "ZakazivanjeTreninga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZakazivanjeTreninga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrami)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnZakaziTrening;
        private System.Windows.Forms.DataGridView dgvProgrami;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}