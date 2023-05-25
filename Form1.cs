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
        AdministrarePersoane_FisierText adminPersoane;
        int nrPersoane = 0;
        List<Persoana> persoane;
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
            persoane = adminPersoane.GetPersoane();

            this.Size = new Size(600, 400);
            dateTimeZiDeNastere.Format = DateTimePickerFormat.Long;
            dataGridPersoane.Visible = false;
        }
        private void AfiseazaPersoane(List<Persoana> persoane)
        {
            this.Width = 1200;
            //adminPersoane.GetPersoane();
            dataGridPersoane.DataSource = null;
            dataGridPersoane.DataSource = persoane;
            dataGridPersoane.Visible = true;
        }

        private void AscundePersoane()
        {
            dataGridPersoane.Visible = false;
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
            AfiseazaPersoane(persoane);
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            AscundePersoane();
            this.Width = 600;
        }
        private void ResetareControale()
        {
            txtAddNume.Text = txtAddEmail.Text = txtAddNumarDeTelefon.Text = string.Empty;
            checkFamilie.Checked = false;
            checkPrieteni.Checked = false;
            checkServiciu.Checked = false;
            grupuriSelectate.Clear();
        }
        private bool ValidareEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidareDate()
        {
            if (txtAddNume.Text.Length < 3 || txtAddNume.Text.Length > 15 || !int.TryParse(txtAddNumarDeTelefon.Text.Replace(" ", ""), out int numarDeTelefon) || txtAddNumarDeTelefon.Text.Length < 9 || !ValidareEmail(txtAddEmail.Text) || (checkFamilie.Checked == false && checkPrieteni.Checked == false && checkServiciu.Checked == false))
                return false;
            return true;
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidareDate())
            {
                Persoana persoana = new Persoana();
                Persoana.Grup grup = persoana.GetGrup(string.Join(", ", grupuriSelectate.Cast<string>().ToArray()));
                persoana.grupuri = grupuriSelectate;
                persoana.nume = txtAddNume.Text;
                persoana.ziDeNastere = DateTime.Parse(dateTimeZiDeNastere.Text);
                int numarDeTelefon;
                int.TryParse(txtAddNumarDeTelefon.Text.Replace(" ", ""), out numarDeTelefon);
                persoana.numarDeTelefon = numarDeTelefon;
                persoana.email = txtAddEmail.Text;
                persoana._grup = grup;
                nrPersoane++;
                persoana.idPersoana = nrPersoane++;
                adminPersoane.AddPersoana(persoana);
                persoane.Add(persoana);
                lblAddNume.ForeColor = Color.LightSeaGreen;
                lblAddEmail.ForeColor = Color.LightSeaGreen;
                lblAddNumărDeTelefon.ForeColor = Color.LightSeaGreen;
                AfiseazaPersoane(persoane);
            }
            else
            {
                lblAddNume.ForeColor = Color.Red;
                lblAddEmail.ForeColor = Color.Red;
                lblAddNumărDeTelefon.ForeColor = Color.Red;
                txtAddNume.Text = "Numele trebuie sa contina intre 3 si 15 caractere";
                txtAddNumarDeTelefon.Text = "Numarul de telefon trebuie sa contina cel putin 9 cifre";
                txtAddEmail.Text = "Aceasta nu este o adresa de telefon valida";
            }
            ResetareControale();
        }

        private void dateGridPersoane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSterge.Select();
            btnSterge.BackColor = Color.LightSeaGreen;
            btnSterge.ForeColor = Color.White;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int randSelectat = dataGridPersoane.CurrentRow.Index;
            int persoanaID = (int)dataGridPersoane.Rows[randSelectat].Cells[2].Value;
            adminPersoane.StergePersoana(persoane, persoanaID);
            AfiseazaPersoane(persoane);
            dataGridPersoane.DataSource = null;
            dataGridPersoane.DataSource = persoane;
            btnSterge.BackColor = Color.White;
            btnSterge.ForeColor = Color.LightSeaGreen;
        }
    }
}

/*to do:
 1. data validation
 2. search functions
 3. delete function
 4. figure out why the calendar isn't changing*/
