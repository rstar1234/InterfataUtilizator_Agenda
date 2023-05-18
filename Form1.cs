using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda;

namespace InterfataUtilizator_Agenda
{
    public partial class Form1 : Form
    {
        Label[] eticheteNume;
        Label[] eticheteZiDeNastere;
        Label[] eticheteNumarDeTelefon;
        Label[] eticheteGrup;
        Label[] eticheteEmail;
        AdministrarePersoane_FisierText adminPersoane;
        int nrPersoane = 0;
        ArrayList grupuriSelectate = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie =
            Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminPersoane = new
            Agenda.AdministrarePersoane_FisierText(caleCompletaFisier);

            this.Size = new Size(600, 400);
            dateTimeZiDeNastere.Format = DateTimePickerFormat.Long;
        }
        private void AfiseazaPersoane()
        {
            this.Width = 1200;
            adminPersoane.GetPersoane(out nrPersoane);
            eticheteNume = new Label[nrPersoane];
            eticheteZiDeNastere = new Label[nrPersoane];
            eticheteNumarDeTelefon = new Label[nrPersoane];
            eticheteEmail = new Label[nrPersoane];
            eticheteGrup = new Label[nrPersoane];  
            Persoana[] persoane = adminPersoane.GetPersoane(out nrPersoane);
            lbITitlu.Visible = true;
            lblNume.Visible = true;
            lblZiDeNastere.Visible = true;
            lblNumarDeTelefon.Visible = true;
            lblEmail.Visible = true;
            lblGrup.Visible = true;
            for (int i = 0; i < nrPersoane; i++)
            {
                eticheteNume[i] = new Label
                {
                    Text = persoane[i].nume,
                    ForeColor = Color.LightSeaGreen,
                    Visible = true,
                    Size = new Size(51, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true,
                    Top = 100 + i * 20,
                    Left = 399,
                };
                //this.Controls.Add(eticheteNume[i]);
                eticheteZiDeNastere[i] = new Label
                {
                    Text = persoane[i].ziDeNastere.ToString("ddd, dd MMMM yyyy"),
                    ForeColor = Color.LightSeaGreen,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 521,
                    Size = new Size(140, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteZiDeNastere[i]);
                eticheteNumarDeTelefon[i] = new Label
                {
                    Text = persoane[i].numarDeTelefon.ToString(),
                    ForeColor = Color.LightSeaGreen,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 679,
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteNumarDeTelefon[i]);
                eticheteEmail[i] = new Label
                {
                    Text = persoane[i].email,
                    ForeColor = Color.LightSeaGreen,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 854,
                    Size = new Size(120, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteEmail[i]);
                eticheteGrup[i] = new Label
                {
                    Text = persoane[i].GrupAsString,
                    ForeColor = Color.LightSeaGreen,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 993,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteGrup[i]);
            }
            for (int i = 0; i < nrPersoane; i++)
            {
                this.Controls.Add(eticheteNume[i]);
                this.Controls.Add(eticheteZiDeNastere[i]);
                this.Controls.Add(eticheteNumarDeTelefon[i]);
                this.Controls.Add(eticheteEmail[i]);
                this.Controls.Add(eticheteGrup[i]);
            }
        }

        private void AscundePersoane()
        {
            lbITitlu.Visible = false;
            lblNume.Visible = false;
            lblZiDeNastere.Visible = false;
            lblNumarDeTelefon.Visible = false;
            lblEmail.Visible = false;
            lblGrup.Visible = false;
            for(int i = 0; i < nrPersoane; i++)
            {
                this.Controls.Remove(eticheteNume[i]);
                this.Controls.Remove(eticheteZiDeNastere[i]);
                this.Controls.Remove(eticheteNumarDeTelefon[i]);
                this.Controls.Remove(eticheteEmail[i]);
                this.Controls.Remove(eticheteGrup[i]);
            }
        }

        private void CheckGrupuri_CheckedChange(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string grupSelectat = checkBox.Text;

            if(checkBox.Checked == true)
            {
                grupuriSelectate.Add(grupSelectat);
            }
            else
            {
                grupuriSelectate.Remove(grupSelectat);
            }
        }
        
        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaPersoane();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            AscundePersoane();
            this.Width = 600;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Persoana persoana = new Persoana();
            Persoana.Grup grup = persoana.GetGrup(string.Join(", ", grupuriSelectate.Cast<string>().ToArray()));
            persoana.grupuri = grupuriSelectate;
            persoana.nume = txtAddNume.Text;
            persoana.ziDeNastere = DateTime.Parse(dateTimeZiDeNastere.Text);
            persoana.numarDeTelefon = Convert.ToInt32(txtAddNumarDeTelefon.Text);
            persoana.email = txtAddEmail.Text;
            persoana._grup = grup;
            persoana.idPersoana = nrPersoane++;
            adminPersoane.AddPersoana(persoana);
            AfiseazaPersoane();
        }

        private void Lbl_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Vizibilitatea s-a schimbat!");
        }
    }
}
/*to do:
 1. data validation
 2. search functions
 3. delete function
 4. figure out why the calendar isn't changing*/
