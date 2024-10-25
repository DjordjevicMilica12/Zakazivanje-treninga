namespace Server
{
    partial class Form1
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
            this.btnpokreni = new System.Windows.Forms.Button();
            this.btnzaustavi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpokreni
            // 
            this.btnpokreni.Location = new System.Drawing.Point(79, 54);
            this.btnpokreni.Name = "btnpokreni";
            this.btnpokreni.Size = new System.Drawing.Size(116, 58);
            this.btnpokreni.TabIndex = 0;
            this.btnpokreni.Text = "Pokreni server";
            this.btnpokreni.UseVisualStyleBackColor = true;
            this.btnpokreni.Click += new System.EventHandler(this.pokreni_Click);
            // 
            // btnzaustavi
            // 
            this.btnzaustavi.Location = new System.Drawing.Point(271, 54);
            this.btnzaustavi.Name = "btnzaustavi";
            this.btnzaustavi.Size = new System.Drawing.Size(113, 58);
            this.btnzaustavi.TabIndex = 1;
            this.btnzaustavi.Text = "Zaustavi server";
            this.btnzaustavi.UseVisualStyleBackColor = true;
            this.btnzaustavi.Click += new System.EventHandler(this.btnzaustavi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnzaustavi);
            this.Controls.Add(this.btnpokreni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpokreni;
        private System.Windows.Forms.Button btnzaustavi;
        private System.Windows.Forms.Label label1;
    }
}

