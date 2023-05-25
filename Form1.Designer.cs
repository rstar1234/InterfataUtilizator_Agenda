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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSterge = new System.Windows.Forms.Button();
            this.dataGridPersoane = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).BeginInit();
            this.SuspendLayout();
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
            this.txtAddNume.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddNume.Location = new System.Drawing.Point(225, 46);
            this.txtAddNume.Name = "txtAddNume";
            this.txtAddNume.Size = new System.Drawing.Size(298, 26);
            this.txtAddNume.TabIndex = 11;
            // 
            // txtAddNumarDeTelefon
            // 
            this.txtAddNumarDeTelefon.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddNumarDeTelefon.Location = new System.Drawing.Point(225, 202);
            this.txtAddNumarDeTelefon.Name = "txtAddNumarDeTelefon";
            this.txtAddNumarDeTelefon.Size = new System.Drawing.Size(298, 26);
            this.txtAddNumarDeTelefon.TabIndex = 13;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.btnAfiseaza.Location = new System.Drawing.Point(338, 471);
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
            // btnSterge
            // 
            this.btnSterge.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSterge.Location = new System.Drawing.Point(438, 471);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(85, 35);
            this.btnSterge.TabIndex = 21;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // dataGridPersoane
            // 
            this.dataGridPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPersoane.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPersoane.Location = new System.Drawing.Point(621, 56);
            this.dataGridPersoane.Name = "dataGridPersoane";
            this.dataGridPersoane.RowHeadersWidth = 62;
            this.dataGridPersoane.RowTemplate.Height = 28;
            this.dataGridPersoane.Size = new System.Drawing.Size(985, 450);
            this.dataGridPersoane.TabIndex = 22;
            this.dataGridPersoane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateGridPersoane_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 544);
            this.Controls.Add(this.dataGridPersoane);
            this.Controls.Add(this.btnSterge);
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
            this.Name = "Form1";
            this.Text = "Agenda";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dataGridPersoane;
    }
}

