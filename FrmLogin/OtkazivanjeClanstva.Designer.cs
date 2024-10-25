namespace FrmLogin
{
    partial class OtkazivanjeClanstva
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
            this.btnOtkaziClanstvo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDeca
            // 
            this.cmbDeca.FormattingEnabled = true;
            this.cmbDeca.Location = new System.Drawing.Point(68, 80);
            this.cmbDeca.Name = "cmbDeca";
            this.cmbDeca.Size = new System.Drawing.Size(224, 24);
            this.cmbDeca.TabIndex = 0;
            this.cmbDeca.SelectedIndexChanged += new System.EventHandler(this.cmbDeca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite dete kome zelite da otkazete clanstvo";
            // 
            // btnOtkaziClanstvo
            // 
            this.btnOtkaziClanstvo.Location = new System.Drawing.Point(68, 152);
            this.btnOtkaziClanstvo.Name = "btnOtkaziClanstvo";
            this.btnOtkaziClanstvo.Size = new System.Drawing.Size(141, 36);
            this.btnOtkaziClanstvo.TabIndex = 2;
            this.btnOtkaziClanstvo.Text = "Otkazi clanstvo";
            this.btnOtkaziClanstvo.UseVisualStyleBackColor = true;
            this.btnOtkaziClanstvo.Click += new System.EventHandler(this.btnOtkaziClanstvo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // OtkazivanjeClanstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtkaziClanstvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeca);
            this.Name = "OtkazivanjeClanstva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otkazivanje Clanstva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtkaziClanstvo;
        private System.Windows.Forms.Label label2;
    }
}