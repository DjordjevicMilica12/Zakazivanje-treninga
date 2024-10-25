namespace FrmLogin
{
    partial class OtkazivanjeTreninga
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
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.btnOtkaziTrening = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treninzi koji su zakazani";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(22, 96);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(564, 207);
            this.dgvTreninzi.TabIndex = 1;
            this.dgvTreninzi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellClick);
            // 
            // btnOtkaziTrening
            // 
            this.btnOtkaziTrening.Location = new System.Drawing.Point(460, 331);
            this.btnOtkaziTrening.Name = "btnOtkaziTrening";
            this.btnOtkaziTrening.Size = new System.Drawing.Size(126, 40);
            this.btnOtkaziTrening.TabIndex = 2;
            this.btnOtkaziTrening.Text = "Otkazi trening";
            this.btnOtkaziTrening.UseVisualStyleBackColor = true;
            this.btnOtkaziTrening.Click += new System.EventHandler(this.btnOtkaziTrening_Click);
            // 
            // OtkazivanjeTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 456);
            this.Controls.Add(this.btnOtkaziTrening);
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.label1);
            this.Name = "OtkazivanjeTreninga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtkazivanjeTreninga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.Button btnOtkaziTrening;
    }
}