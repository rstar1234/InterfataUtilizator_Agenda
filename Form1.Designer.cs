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
            this.lblAddNume = new System.Windows.Forms.Label();
            this.lblAddZiDeNastere = new System.Windows.Forms.Label();
            this.lblAddNumărDeTelefon = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddGrup = new System.Windows.Forms.Label();
            this.txtAddNume = new System.Windows.Forms.TextBox();
            this.txtAddNumarDeTelefon = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.checkPrieteni = new System.Windows.Forms.CheckBox();
            this.checkFamilie = new System.Windows.Forms.CheckBox();
            this.checkServiciu = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.dateTimeZiDeNastere = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbITitlu
            // 
            this.lbITitlu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbITitlu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbITitlu.Location = new System.Drawing.Point(599, 33);
            this.lbITitlu.Name = "lbITitlu";
            this.lbITitlu.Size = new System.Drawing.Size(1032, 33);
            this.lbITitlu.TabIndex = 0;
            this.lbITitlu.Text = "Agenda";
            this.lbITitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbITitlu.Visible = false;
            this.lbITitlu.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNume.Location = new System.Drawing.Point(599, 100);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            this.lblNume.Visible = false;
            this.lblNume.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGrup.Location = new System.Drawing.Point(1489, 100);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(45, 20);
            this.lblGrup.TabIndex = 2;
            this.lblGrup.Text = "Grup";
            this.lblGrup.Visible = false;
            this.lblGrup.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmail.Location = new System.Drawing.Point(1281, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            this.lblEmail.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblNumarDeTelefon
            // 
            this.lblNumarDeTelefon.AutoSize = true;
            this.lblNumarDeTelefon.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNumarDeTelefon.Location = new System.Drawing.Point(1018, 100);
            this.lblNumarDeTelefon.Name = "lblNumarDeTelefon";
            this.lblNumarDeTelefon.Size = new System.Drawing.Size(131, 20);
            this.lblNumarDeTelefon.TabIndex = 4;
            this.lblNumarDeTelefon.Text = "Număr de telefon";
            this.lblNumarDeTelefon.Visible = false;
            this.lblNumarDeTelefon.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblZiDeNastere
            // 
            this.lblZiDeNastere.AutoSize = true;
            this.lblZiDeNastere.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblZiDeNastere.Location = new System.Drawing.Point(782, 100);
            this.lblZiDeNastere.Name = "lblZiDeNastere";
            this.lblZiDeNastere.Size = new System.Drawing.Size(104, 20);
            this.lblZiDeNastere.TabIndex = 5;
            this.lblZiDeNastere.Text = "Zi de Nastere";
            this.lblZiDeNastere.Visible = false;
            this.lblZiDeNastere.VisibleChanged += new System.EventHandler(this.Lbl_VisibleChanged);
            // 
            // lblAddNume
            // 
            this.lblAddNume.AutoSize = true;
            this.lblAddNume.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAddNume.Location = new System.Drawing.Point(50, 46);
            this.lblAddNume.Name = "lblAddNume";
            this.lblAddNume.Size = new System.Drawing.Size(51, 20);
            this.lblAddNume.TabIndex = 6;
            this.lblAddNume.Text = "Nume";
            // 
            // lblAddZiDeNastere
            // 
            this.lblAddZiDeNastere.AutoSize = true;
            this.lblAddZiDeNastere.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAddZiDeNastere.Location = new System.Drawing.Point(50, 119);
            this.lblAddZiDeNastere.Name = "lblAddZiDeNastere";
            this.lblAddZiDeNastere.Size = new System.Drawing.Size(104, 20);
            this.lblAddZiDeNastere.TabIndex = 7;
            this.lblAddZiDeNastere.Text = "Zi de Nastere";
            // 
            // lblAddNumărDeTelefon
            // 
            this.lblAddNumărDeTelefon.AutoSize = true;
            this.lblAddNumărDeTelefon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAddNumărDeTelefon.Location = new System.Drawing.Point(50, 192);
            this.lblAddNumărDeTelefon.Name = "lblAddNumărDeTelefon";
            this.lblAddNumărDeTelefon.Size = new System.Drawing.Size(131, 20);
            this.lblAddNumărDeTelefon.TabIndex = 8;
            this.lblAddNumărDeTelefon.Text = "Număr de telefon";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAddEmail.Location = new System.Drawing.Point(50, 265);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAddEmail.TabIndex = 9;
            this.lblAddEmail.Text = "Email";
            // 
            // lblAddGrup
            // 
            this.lblAddGrup.AutoSize = true;
            this.lblAddGrup.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAddGrup.Location = new System.Drawing.Point(50, 338);
            this.lblAddGrup.Name = "lblAddGrup";
            this.lblAddGrup.Size = new System.Drawing.Size(45, 20);
            this.lblAddGrup.TabIndex = 10;
            this.lblAddGrup.Text = "Grup";
            // 
            // txtAddNume
            // 
            this.txtAddNume.Location = new System.Drawing.Point(225, 46);
            this.txtAddNume.Name = "txtAddNume";
            this.txtAddNume.Size = new System.Drawing.Size(298, 26);
            this.txtAddNume.TabIndex = 11;
            // 
            // txtAddNumarDeTelefon
            // 
            this.txtAddNumarDeTelefon.Location = new System.Drawing.Point(225, 202);
            this.txtAddNumarDeTelefon.Name = "txtAddNumarDeTelefon";
            this.txtAddNumarDeTelefon.Size = new System.Drawing.Size(298, 26);
            this.txtAddNumarDeTelefon.TabIndex = 13;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(225, 280);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(298, 26);
            this.txtAddEmail.TabIndex = 14;
            // 
            // checkPrieteni
            // 
            this.checkPrieteni.AutoSize = true;
            this.checkPrieteni.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.checkPrieteni.Location = new System.Drawing.Point(225, 338);
            this.checkPrieteni.Name = "checkPrieteni";
            this.checkPrieteni.Size = new System.Drawing.Size(88, 24);
            this.checkPrieteni.TabIndex = 15;
            this.checkPrieteni.Text = "Prieteni";
            this.checkPrieteni.UseVisualStyleBackColor = true;
            this.checkPrieteni.CheckedChanged += new System.EventHandler(this.CheckGrupuri_CheckedChange);
            // 
            // checkFamilie
            // 
            this.checkFamilie.AutoSize = true;
            this.checkFamilie.BackColor = System.Drawing.SystemColors.Control;
            this.checkFamilie.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.checkFamilie.Location = new System.Drawing.Point(380, 338);
            this.checkFamilie.Name = "checkFamilie";
            this.checkFamilie.Size = new System.Drawing.Size(85, 24);
            this.checkFamilie.TabIndex = 16;
            this.checkFamilie.Text = "Familie";
            this.checkFamilie.UseVisualStyleBackColor = false;
            this.checkFamilie.CheckedChanged += new System.EventHandler(this.CheckGrupuri_CheckedChange);
            // 
            // checkServiciu
            // 
            this.checkServiciu.AutoSize = true;
            this.checkServiciu.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.checkServiciu.Location = new System.Drawing.Point(225, 410);
            this.checkServiciu.Name = "checkServiciu";
            this.checkServiciu.Size = new System.Drawing.Size(90, 24);
            this.checkServiciu.TabIndex = 17;
            this.checkServiciu.Text = "Serviciu";
            this.checkServiciu.UseVisualStyleBackColor = true;
            this.checkServiciu.CheckedChanged += new System.EventHandler(this.CheckGrupuri_CheckedChange);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(225, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Adaugă";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAfiseaza.Location = new System.Drawing.Point(380, 471);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(85, 35);
            this.btnAfiseaza.TabIndex = 19;
            this.btnAfiseaza.Text = "Afișează";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // dateTimeZiDeNastere
            // 
            this.dateTimeZiDeNastere.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimeZiDeNastere.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dateTimeZiDeNastere.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
            this.dateTimeZiDeNastere.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimeZiDeNastere.Location = new System.Drawing.Point(225, 119);
            this.dateTimeZiDeNastere.Name = "dateTimeZiDeNastere";
            this.dateTimeZiDeNastere.Size = new System.Drawing.Size(298, 26);
            this.dateTimeZiDeNastere.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 544);
            this.Controls.Add(this.dateTimeZiDeNastere);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkServiciu);
            this.Controls.Add(this.checkFamilie);
            this.Controls.Add(this.checkPrieteni);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.txtAddNumarDeTelefon);
            this.Controls.Add(this.txtAddNume);
            this.Controls.Add(this.lblAddGrup);
            this.Controls.Add(this.lblAddEmail);
            this.Controls.Add(this.lblAddNumărDeTelefon);
            this.Controls.Add(this.lblAddZiDeNastere);
            this.Controls.Add(this.lblAddNume);
            this.Controls.Add(this.lblZiDeNastere);
            this.Controls.Add(this.lblNumarDeTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGrup);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lbITitlu);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.Click += new System.EventHandler(this.Form1_Click);
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
        private System.Windows.Forms.Label lblAddNume;
        private System.Windows.Forms.Label lblAddZiDeNastere;
        private System.Windows.Forms.Label lblAddNumărDeTelefon;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddGrup;
        private System.Windows.Forms.TextBox txtAddNume;
        private System.Windows.Forms.TextBox txtAddNumarDeTelefon;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.CheckBox checkPrieteni;
        private System.Windows.Forms.CheckBox checkFamilie;
        private System.Windows.Forms.CheckBox checkServiciu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.DateTimePicker dateTimeZiDeNastere;
    }
}

