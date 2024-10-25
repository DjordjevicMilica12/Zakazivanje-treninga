namespace FrmLogin
{
    partial class UnosSLobodnogTermina
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
            this.lblUnos = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbDatumi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(44, 42);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(96, 16);
            this.lblUnos.TabIndex = 0;
            this.lblUnos.Text = "Unesite datum:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(47, 80);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(186, 22);
            this.txtDatum.TabIndex = 1;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(47, 147);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(115, 32);
            this.btnUnos.TabIndex = 2;
            this.btnUnos.Text = "Unesite datum";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.Location = new System.Drawing.Point(56, 41);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(90, 16);
            this.lblObrisi.TabIndex = 3;
            this.lblObrisi.Text = "Izberite datum";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(59, 147);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(115, 32);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi datum";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmbDatumi
            // 
            this.cmbDatumi.FormattingEnabled = true;
            this.cmbDatumi.Location = new System.Drawing.Point(59, 80);
            this.cmbDatumi.Name = "cmbDatumi";
            this.cmbDatumi.Size = new System.Drawing.Size(174, 24);
            this.cmbDatumi.TabIndex = 5;
            this.cmbDatumi.SelectedIndexChanged += new System.EventHandler(this.cmbDatumi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // UnosSLobodnogTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDatumi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblUnos);
            this.Name = "UnosSLobodnogTermina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label lblObrisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbDatumi;
        private System.Windows.Forms.Label label1;
    }
}