using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dierenartsenpraktijk.Model;
using Dierenartsenpraktijk.Data;

namespace Dierenartsenpraktijk.Forms
{
    public partial class FormDierenartsen : Form
    {
        public FormDierenartsen()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Dierenarts repository om mee te werken
        DierenartsRepository dierenartsRepository = new DierenartsRepository();
        //attribuut om dierenartsen in lijst op te slaan
        List<Dierenarts> LijstDierenartsen = new List<Dierenarts>();
        //Selected dierenarts
        Dierenarts selectedArts;

        //functie om lijst van dierenartsen weer te geven in listbox
        private void zetDierenartsenInListbox(List<Dierenarts> list)
        {
            //steeds resetten van geselecteerde arts en textboxen terug leegmaken
            selectedArts = null;
            textBoxAchternaam.Text = "";
            textBoxVoornaam.Text = "";
            textBoxTelefoonnummer.Text = "";
            textBoxSpecialisatie.Text = "";


            listBoxDierenartsen.Items.Clear();
            listBoxDierenartsen.Items.Add("-Id- \t -Naam- \t \t \t-Telefoon- \t -Specialisatie-");
            foreach (Dierenarts arts in list)
            {
                int? id = arts.Id;
                string voornaam = arts.Voornaam;
                string achternaam = arts.Achternaam;
                int telefoonnummer = arts.Telefoonnummer;
                SpecialisatieType specialisatie = arts.Specialisatie;
                string inputItem = id + "\t" + voornaam + " " + achternaam + "\t \t 0" + telefoonnummer + "\t" + specialisatie.ToString(); 
                listBoxDierenartsen.Items.Add(inputItem);
            }
        }

        private void buttonToonAlle_Click(object sender, EventArgs e)
        {
           LijstDierenartsen = dierenartsRepository.GeefAlle();
           zetDierenartsenInListbox(LijstDierenartsen);
        }


        //Dit is de buttonGeefOpNaam (iets fout gegaan met naamgeveing hier)
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNaamIngave.Text == "Geef naam in" || textBoxNaamIngave.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om dierenartsen te zoeken");
                return;
            }
            LijstDierenartsen = dierenartsRepository.GeefOpNaam(textBoxNaamIngave.Text);
            zetDierenartsenInListbox(LijstDierenartsen);
        }


        private void buttonSelecteer_Click(object sender, EventArgs e)
        {
            int index = listBoxDierenartsen.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedArts = LijstDierenartsen[index];
            labelSelectedArts.Text = "Dierenarts " + selectedArts.Id + ":";
            textBoxVoornaam.Text = selectedArts.Voornaam;
            textBoxAchternaam.Text = selectedArts.Achternaam;
            textBoxTelefoonnummer.Text = selectedArts.Telefoonnummer.ToString();
            textBoxSpecialisatie.Text = selectedArts.Specialisatie.ToString();
        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedArts.Voornaam + " " + selectedArts.Achternaam + "[id: " + selectedArts.Id + "] werd verwijderd uit de database");
            dierenartsRepository.Delete(this.selectedArts);
            //steeds resetten van geselecteerde arts en textboxen terug leegmaken
            selectedArts = null;
            textBoxAchternaam.Text = "";
            textBoxVoornaam.Text = "";
            textBoxTelefoonnummer.Text = "";
            textBoxSpecialisatie.Text = "";
            
        }





        //methode om ingave van correct telefoonnummer te controleren
        private bool foutTelefoonnummer(string textIngave)
        {
            if (textIngave == "" || textIngave == null)
            {
                return true;
            }
            if (textIngave.ToCharArray()[0] != '0' || textIngave.ToCharArray()[1] != '4' || textIngave.ToCharArray()[2] != '7')
            {
                return true;
            }
            foreach(char i in textIngave.ToCharArray())
            {
                if (!char.IsDigit(i))
                {
                    return true;
                }
            }
            if(textIngave.Length != 10)
            {

                return true;
            }
            return false;
        }

        //methode om ingave specialisatie type te controleren
        private bool foutSpecialisatietype(string textIngave)
        {
            textIngave = textIngave.ToLower();
            if(textIngave == "kattenenhonden" || textIngave == "reptielen" || textIngave == "vogels" || textIngave == "knaagdieren")
            {
                return false;
            }
            return true;
        }

        //Updaten van gegevens van bestaande dierenartsen
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxVoornaam.Text == null || textBoxVoornaam.Text == "")
            {
                MessageBox.Show("Vul een voornaam in");
                return;
            }
            if (textBoxAchternaam.Text == null || textBoxAchternaam.Text == "")
            {
                MessageBox.Show("Vul een achternaam in");
                return;
            }
            if (foutTelefoonnummer(textBoxTelefoonnummer.Text)){
                MessageBox.Show("Telefoonnummer bevat enkel cijfers en is 10 cijfers lang, startende met 047XXXXXXX");
                return;
            }
            if (foutSpecialisatietype(textBoxSpecialisatie.Text)){
                MessageBox.Show("Incorrecte specialisatie, kies uit: KattenEnHonden, Reptielen, Vogels of Knaagdieren");
                return;
            }
            selectedArts.Voornaam = textBoxVoornaam.Text;
            selectedArts.Achternaam = textBoxAchternaam.Text;
            selectedArts.Telefoonnummer = 0 + int.Parse(textBoxTelefoonnummer.Text);
            selectedArts.Specialisatie = dierenartsRepository.mapSpecialisatieType(textBoxSpecialisatie.Text);
            dierenartsRepository.Opslaan(selectedArts);
            MessageBox.Show("Dierenarts: " + selectedArts.ToString() + " werd geupdated");
        }


        //Nieuwe dierenarts aanmaken
        private void buttonVoegToe_Click(object sender, EventArgs e)
        {
            if(textBoxVoornaamNieuwe.Text == null || textBoxVoornaamNieuwe.Text == "")
            {
                MessageBox.Show("Vul een voornaam in");
                return;
            }
            if (textBoxAchternaamNieuwe.Text == null || textBoxAchternaamNieuwe.Text == "")
            {
                MessageBox.Show("Vul een achternaam in");
                return;
            }
            if (foutTelefoonnummer(textBoxTelefoonNieuwe.Text))
            {
                MessageBox.Show("Telefoonnummer bevat enkel cijfers en is 10 cijfers lang, startende met 047XXXXXXX");
                return;
            }
            if (foutSpecialisatietype(textBoxSpecialisatieNieuwe.Text))
            {
                MessageBox.Show("Incorrecte specialisatie, kies uit: KattenEnHonden, Reptielen, Vogels of Knaagdieren");
                return;
            }
            string voornaam = textBoxVoornaamNieuwe.Text;
            string achternaam = textBoxAchternaamNieuwe.Text;
            int telefoonnummer = 0 + Int32.Parse(textBoxTelefoonNieuwe.Text);
            SpecialisatieType specialisatie = dierenartsRepository.mapSpecialisatieType(textBoxSpecialisatie.Text);
            Dierenarts nieuweDierenarts = new Dierenarts(voornaam, achternaam, telefoonnummer, specialisatie);
            dierenartsRepository.Opslaan(nieuweDierenarts);
            MessageBox.Show("Dierenarts: " + nieuweDierenarts.ToString() + " werd toegevoegd");
            textBoxVoornaamNieuwe.Text = "";
            textBoxAchternaamNieuwe.Text = "";
            textBoxTelefoonNieuwe.Text = "";
            textBoxSpecialisatieNieuwe.Text = "";
        }
    }
}
