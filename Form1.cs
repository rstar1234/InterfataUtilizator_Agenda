using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda;

namespace InterfataUtilizator_Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie =
            Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrarePersoane_FisierText adminPersoane = new
            Agenda.AdministrarePersoane_FisierText(caleCompletaFisier);
            int nrPersoane = 0;
            Persoana[] persoane = adminPersoane.GetPersoane(out nrPersoane);
           
            Label[] eticheteNume = new Label[nrPersoane];
            Label[] eticheteZiDeNastere = new Label[nrPersoane];
            Label[] eticheteNumarDeTelefon = new Label[nrPersoane];
            Label[] eticheteGrup = new Label[nrPersoane];
            Label[] eticheteEmail = new Label[nrPersoane];

            for (int i = 0; i < nrPersoane; i++)
            {
                eticheteNume[i] = new Label
                {
                    Text = persoane[i].nume,
                    ForeColor = Color.DarkOrchid,
                    Visible = true,
                    Size = new Size(51, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true,
                    Top = 100+i*20,
                    Left = 85,
                };                
                //this.Controls.Add(eticheteNume[i]);
                eticheteZiDeNastere[i] = new Label
                {
                    Text = persoane[i].ziDeNastere.ToString(),
                    ForeColor = Color.DarkOrchid,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 204,
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteZiDeNastere[i]);
                eticheteNumarDeTelefon[i] = new Label
                {
                    Text = persoane[i].numarDeTelefon.ToString(),
                    ForeColor = Color.DarkOrchid,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 361,
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteNumarDeTelefon[i]);
                eticheteEmail[i] = new Label
                {
                    Text = persoane[i].email,
                    ForeColor = Color.DarkOrchid,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 539,
                    Size = new Size(100, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteEmail[i]);
                eticheteGrup[i] = new Label
                {
                    Text = persoane[i]._grup.ToString(),
                    ForeColor = Color.DarkOrchid,
                    Visible = true,
                    Top = 100 + i * 20,
                    Left = 654,
                    Size = new Size(60, 20),
                    TextAlign = ContentAlignment.TopLeft,
                    Enabled = true
                };
                //this.Controls.Add(eticheteGrup[i]);
            }
            for(int i = 0; i < nrPersoane; i++)
            {
                this.Controls.Add(eticheteNume[i]);
                this.Controls.Add(eticheteZiDeNastere[i]);
                this.Controls.Add(eticheteNumarDeTelefon[i]);
                this.Controls.Add(eticheteEmail[i]);
                this.Controls.Add(eticheteGrup[i]);
            }
        }
    }
}
