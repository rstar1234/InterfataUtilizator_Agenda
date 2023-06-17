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
        List<Persoana> persoane = new List<Persoana>();
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

            this.Size = new Size(850, 500);
            dateTimeZiDeNastere.Format = DateTimePickerFormat.Long;
            //pentru calculatoarele setate in limba romana, afiseaza "zi a saptamanii, zi luna an"
            dataGridPersoane.Visible = false;
            //formularul se va lati cand se va apasa butonul "Afiseaza" si atunci va aparea controlul dataGridview
            //este setat invizibil pentru a preveni afisarea trunchiata pe un formular mai putin lat
        }
        private void AfiseazaPersoane(List<Persoana> persoane)
        {
            //lateste formularul si afiseaza controlul dataGridView
            this.Width = 1200;
            dataGridPersoane.DataSource = null;
            dataGridPersoane.DataSource = persoane;
            dataGridPersoane.Columns[4].DefaultCellStyle.Format = "dd MMMM yyyy";
            //pentru ca ziua de nastere sa fie afisata in formatul "zi luna_neprescurtata an"
            dataGridPersoane.Visible = true;
        }

        private void AscundePersoane()
        {
            dataGridPersoane.Visible = false;
        }

        private void CheckGrupuri_CheckedChange(object sender, EventArgs e)
        {
            //tinem eveidenta casetelor marcate cu ajutorul unui ArrayList
            CheckBox checkBox = sender as CheckBox;
            string grupSelectat = checkBox.Text;

            if (checkBox.Checked == true)
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
            //formularul revine la latimea initiala si ascunde controlul dataGridView
            AscundePersoane();
            this.Width = 850;
        }
        private void ResetareControale()
        {
            //golim controalele pentru a facilita adaugarea unei noi persoane
            txtAddNume.Text = txtAddEmail.Text = txtAddNumarDeTelefon.Text = string.Empty;
            checkFamilie.Checked = false;
            checkPrieteni.Checked = false;
            checkServiciu.Checked = false;
            grupuriSelectate.Clear();
        }
        private bool ValidareEmail(string email)
        {
            //verificam daca este intr-un format de tipul nume@exemplu.com, nu si daca adresa este reala
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
            if (txtAddNume.Text.Length < 3 || txtAddNume.Text.Length > 15 || !int.TryParse(txtAddNumarDeTelefon.Text.Replace(" ", ""), out int numarDeTelefon) || txtAddNumarDeTelefon.Text.Length < 9 || !ValidareEmail(txtAddEmail.Text) || (checkFamilie.Checked == false && checkPrieteni.Checked == false && checkServiciu.Checked == false) || DateTime.Parse(dateTimeZiDeNastere.Text) >= DateTime.UtcNow)
                return false;
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //daca datele sunt valide, adaucam o persoana noua
            if (ValidareDate())
            {
                Persoana persoana = new Persoana();
                Persoana.Grup grup = persoana.GetGrup(string.Join(", ", grupuriSelectate.Cast<string>().ToArray()));
                //persoana.grupuri = grupuriSelectate;
                persoana.nume = txtAddNume.Text;
                persoana.ziDeNastere = DateTime.Parse(dateTimeZiDeNastere.Text);
                int.TryParse(txtAddNumarDeTelefon.Text.Replace(" ", ""), out int numarDeTelefon);
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
                lblAddGrup.ForeColor = Color.LightSeaGreen;
                lblAddZiDeNastere.ForeColor = Color.LightSeaGreen;
                AfiseazaPersoane(persoane);
            }
            else
            {
                //daca nu, inrosim controalele si atentionam utilizatorul de ce nu sunt bune
                lblAddNume.ForeColor = Color.Red;
                lblAddEmail.ForeColor = Color.Red;
                lblAddNumărDeTelefon.ForeColor = Color.Red;
                lblAddZiDeNastere.ForeColor = Color.Red;
                lblAddGrup.ForeColor = Color.Red;
                /*MessageBox.Show("Numele trebuie sa contina intre 3 si 15 caractere");
                MessageBox.Show("Numarul de telefon trebuie sa contina cel putin 9 cifre");
                MessageBox.Show("Aceasta nu este o adresa de telefon valida");
                MessageBox.Show("Alegeti cel putin un grup");*/
            }
            ResetareControale();
        }

        private void dateGridPersoane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //atragem atentia utilizatorului asupra butonului de stergere
            btnSterge.Select();
            btnSterge.BackColor = Color.LightSeaGreen;
            btnSterge.ForeColor = Color.White;
        }

        private void BtnSterge_Click(object sender, EventArgs e)
        {
            //stergem din fisier si din lista din care se preiau persoanele, apoi reincarcam controlul dataGridView
            int randSelectat = dataGridPersoane.CurrentRow.Index;
            int persoanaID = (int)dataGridPersoane.Rows[randSelectat].Cells[2].Value;

            adminPersoane.StergePersoana(persoane, persoanaID);

            dataGridPersoane.DataSource = null;
            AfiseazaPersoane(persoane);
            btnSterge.BackColor = Color.White;
            btnSterge.ForeColor = Color.LightSeaGreen;
        }
        private List<Persoana> CautaDupaNume(string elementDeCautat)
        {
            //cauta o persoana sau mai multe dupa nume in lista
            List<Persoana> persoaneGasite = new List<Persoana>();
            foreach (Persoana persoana in persoane)
            {
                if (persoana.nume.Contains(elementDeCautat))
                    persoaneGasite.Add(persoana);
            }
            return persoaneGasite;
        }
        private void btnCautaNume_Click(object sender, EventArgs e)
        {
            //afiseaza persoanele cautate in locul listei intregi de persoane
            List<Persoana> persoaneGasite = new List<Persoana>();
            persoaneGasite = CautaDupaNume(txtCauta.Text);
            dataGridPersoane.DataSource = persoaneGasite;
            AfiseazaPersoane(persoaneGasite);
        }

        private List<Persoana> CautaDupaNumarDeTelefon(string elementDeCautat)
        {
            //cauta o persoana sau mai multe dupa numarul de telefon in lista
            List<Persoana> persoaneGasite = new List<Persoana>();
            foreach (Persoana persoana in persoane)
            {
                if (persoana.numarDeTelefon.ToString().Contains(elementDeCautat))
                    persoaneGasite.Add(persoana);
            }
            return persoaneGasite;
        }

        private void btnCautaNumarDeTelefon_Click(object sender, EventArgs e)
        {
            //afiseaza persoanele cautate in locul listei intregi de persoane
            List<Persoana> persoaneGasite = new List<Persoana>();
            persoaneGasite = CautaDupaNumarDeTelefon(txtCauta.Text);
            dataGridPersoane.DataSource = persoaneGasite;
            AfiseazaPersoane(persoaneGasite);
        }

        private List<Persoana> CautaDupaEmail(string elementDeCautat)
        {
            //cauta o persoana sau mai multe dupa adresa de email in lista
            List<Persoana> persoaneGasite = new List<Persoana>();
            foreach (Persoana persoana in persoane)
            {
                if (persoana.email.Contains(elementDeCautat))
                    persoaneGasite.Add(persoana);
            }
            return persoaneGasite;
        }

        private void btnCautaEmail_Click(object sender, EventArgs e)
        {
            //afiseaza persoanele cautate in locul listei intregi de persoane
            List<Persoana> persoaneGasite = new List<Persoana>();
            persoaneGasite = CautaDupaEmail(txtCauta.Text);
            dataGridPersoane.DataSource = persoaneGasite;
            AfiseazaPersoane(persoaneGasite);
        }

        private List<Persoana> CautaLuna(string elementDeCautat)
        {
            //cauta luna in care s-a nascut persoana respectiva
            List<Persoana> persoaneGasite = new List<Persoana>();
            string[] luni = { "ianuarie", "februarie", "martie", "aprilie", "mai", "iunie", "iulie", "august", "aeptembrie", "octombrie", "noiembrie", "decembrie" };
            foreach (Persoana persoana in persoane)
            {
                if (persoana.ziDeNastere.ToString("dd MMMM yyyy").Contains(elementDeCautat) & luni.Contains(elementDeCautat))
                {
                    persoaneGasite.Add(persoana);
                }
            }
            return persoaneGasite;
        }

        private void btnCautaLuna_Click(object sender, EventArgs e)
        {
            //afiseaza persoanele cautate in locul listei intregi de persoane
            List<Persoana> persoaneGasite = new List<Persoana>();
            persoaneGasite = CautaLuna(txtCauta.Text);
            dataGridPersoane.DataSource = persoaneGasite;
            AfiseazaPersoane(persoaneGasite);
        }

        private List<Persoana> CautaGrup(string elementDeCautat)
        {
            //cauta o persoana sau mai multe dupa unul din grupurile din care face parte in lista
            List<Persoana> persoaneGasite = new List<Persoana>();
            foreach (Persoana persoana in persoane)
            {
                if (persoana.GrupAsString.Contains(elementDeCautat))
                    persoaneGasite.Add(persoana);
            }
            return persoaneGasite;
        }

        private void btnCautaGrup_Click(object sender, EventArgs e)
        {
            //afiseaza persoanele cautate in locul listei intregi de persoane
            List<Persoana> persoaneGasite = new List<Persoana>();
            persoaneGasite = CautaGrup(txtCauta.Text);
            dataGridPersoane.DataSource = persoaneGasite;
            AfiseazaPersoane(persoaneGasite);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

/*to do:?
 4. figure out why the calendar isn't changing*/
