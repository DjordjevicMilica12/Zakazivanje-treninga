namespace FrmLogin
{
    partial class PrikaziVezbe
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
            this.dgvVezbe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVezbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezbe su: ";
            // 
            // dgvVezbe
            // 
            this.dgvVezbe.AllowUserToAddRows = false;
            this.dgvVezbe.AllowUserToDeleteRows = false;
            this.dgvVezbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVezbe.Location = new System.Drawing.Point(49, 91);
            this.dgvVezbe.Name = "dgvVezbe";
            this.dgvVezbe.ReadOnly = true;
            this.dgvVezbe.RowHeadersWidth = 51;
            this.dgvVezbe.RowTemplate.Height = 24;
            this.dgvVezbe.Size = new System.Drawing.Size(219, 182);
            this.dgvVezbe.TabIndex = 1;
            // 
            // PrikaziVezbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 344);
            this.Controls.Add(this.dgvVezbe);
            this.Controls.Add(this.label1);
            this.Name = "PrikaziVezbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikaziVezbe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVezbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVezbe;
    }
}