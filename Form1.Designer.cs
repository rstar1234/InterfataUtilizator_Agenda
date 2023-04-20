namespace InterfataUtilizator_Agenda
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
            this.lbITitlu = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblGrup = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumarDeTelefon = new System.Windows.Forms.Label();
            this.lblZiDeNastere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbITitlu
            // 
            this.lbITitlu.BackColor = System.Drawing.Color.DarkRed;
            this.lbITitlu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbITitlu.Location = new System.Drawing.Point(130, 32);
            this.lbITitlu.Name = "lbITitlu";
            this.lbITitlu.Size = new System.Drawing.Size(899, 33);
            this.lbITitlu.TabIndex = 0;
            this.lbITitlu.Text = "Agenda";
            this.lbITitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.Indigo;
            this.lblNume.Location = new System.Drawing.Point(126, 100);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.ForeColor = System.Drawing.Color.Indigo;
            this.lblGrup.Location = new System.Drawing.Point(984, 100);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(45, 20);
            this.lblGrup.TabIndex = 2;
            this.lblGrup.Text = "Grup";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Indigo;
            this.lblEmail.Location = new System.Drawing.Point(805, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNumarDeTelefon
            // 
            this.lblNumarDeTelefon.AutoSize = true;
            this.lblNumarDeTelefon.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumarDeTelefon.Location = new System.Drawing.Point(543, 100);
            this.lblNumarDeTelefon.Name = "lblNumarDeTelefon";
            this.lblNumarDeTelefon.Size = new System.Drawing.Size(131, 20);
            this.lblNumarDeTelefon.TabIndex = 4;
            this.lblNumarDeTelefon.Text = "Număr de telefon";
            // 
            // lblZiDeNastere
            // 
            this.lblZiDeNastere.AutoSize = true;
            this.lblZiDeNastere.ForeColor = System.Drawing.Color.Indigo;
            this.lblZiDeNastere.Location = new System.Drawing.Point(308, 100);
            this.lblZiDeNastere.Name = "lblZiDeNastere";
            this.lblZiDeNastere.Size = new System.Drawing.Size(104, 20);
            this.lblZiDeNastere.TabIndex = 5;
            this.lblZiDeNastere.Text = "Zi de Nastere";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 450);
            this.Controls.Add(this.lblZiDeNastere);
            this.Controls.Add(this.lblNumarDeTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGrup);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lbITitlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbITitlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblGrup;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumarDeTelefon;
        private System.Windows.Forms.Label lblZiDeNastere;
    }
}

