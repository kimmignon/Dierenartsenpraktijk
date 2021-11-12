using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dierenartsenpraktijk.Data;
using Dierenartsenpraktijk.Model;

namespace Dierenartsenpraktijk.Forms
{
    public partial class FormKlanten : Form
    {
        public FormKlanten()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Klant repository om mee te werken
        KlantRepository klantenRepository = new KlantRepository();
        //attribuut om klanten in lijst op te slaan
        List<Klant> LijstKlanten = new List<Klant>();
        //Selected klant
        Klant selectedKlant;

        //functie om lijst van klanten weer te geven in listbox
        private void zetKlantenInListbox(List<Klant> list)
        {
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken
            selectedKlant = null;
            textBoxAchternaam.Text = "";
            textBoxVoornaam.Text = "";
            textBoxTelefoon.Text = "";
            textBoxAdres.Text = "";
            listBoxHuisdieren.Items.Clear();

            listBoxKlanten.Items.Clear();
            listBoxKlanten.Items.Add("-Id- \t -Naam- \t \t \t-Telefoon- \t -Adres-");
            foreach (Klant klant in list)
            {
                int? id = klant.Id;
                string voornaam = klant.Voornaam;
                string achternaam = klant.Achternaam;
                int telefoonnummer = klant.Telefoonnummer;
                string adres = klant.Adres;
                string inputItem = id + "\t" + voornaam + " " + achternaam + "\t \t 0" + telefoonnummer + "\t" + adres;
                listBoxKlanten.Items.Add(inputItem);
            }
        }

        private void buttonGeefAlle_Click(object sender, EventArgs e)
        {
            LijstKlanten = klantenRepository.GeefAlle();
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonOpNaam_Click(object sender, EventArgs e)
        {
            if (textBoxGeefNaam.Text == "Geef naam in" || textBoxGeefNaam.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om dierenartsen te zoeken");
                return;
            }
            LijstKlanten = klantenRepository.GeefOpNaam(textBoxGeefNaam.Text);
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonSelecteer_Click(object sender, EventArgs e)
        {   
            int index = listBoxKlanten.SelectedIndex - 1;
            if(index < 0)
            {
                return;
            }
            this.selectedKlant = LijstKlanten[index];
            labelSelectedKlant.Text = "Klant " + selectedKlant.Id + ":";
            textBoxVoornaam.Text = selectedKlant.Voornaam;
            textBoxAchternaam.Text = selectedKlant.Achternaam;
            textBoxTelefoon.Text = selectedKlant.Telefoonnummer.ToString();
            textBoxAdres.Text = selectedKlant.Adres;
            klantenRepository.GeefDierenKlant(selectedKlant);

            listBoxHuisdieren.Items.Clear();
            listBoxHuisdieren.Items.Add("-Id- \t -Naam- \t \t -soort- \t \t -kleur- \t -Geboortedatum-");
            foreach(Dier dier in selectedKlant.Huisdieren)
            {
                int? id = dier.Id;
                string naam = dier.Naam;
                string soort = dier.Soort;
                string kleur = dier.Kleur;
                DateTime geboortedatum = dier.Geboortedatum;
                string inputItem = id + "\t" + naam + " \t \t" + soort + "\t \t " + kleur + "\t" + geboortedatum;
                listBoxHuisdieren.Items.Add(inputItem);
            }
        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedKlant.Voornaam + " " + selectedKlant.Achternaam + "[id: " + selectedKlant.Id + "] werd verwijderd uit de database");
            klantenRepository.Delete(this.selectedKlant);
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken
            selectedKlant = null;
            textBoxAchternaam.Text = "";
            textBoxVoornaam.Text = "";
            textBoxTelefoon.Text = "";
            textBoxAdres.Text = "";
        }

        //methode om ingave van correct telefoonnummer te controleren
        private bool foutTelefoonnummer(string textIngave)
        {   
            if(textIngave == "" || textIngave == null)
            {
                return true;
            }
            if (textIngave.ToCharArray()[0] != '0' || textIngave.ToCharArray()[1] != '4' || textIngave.ToCharArray()[2] != '7')
            {
                return true;
            }
            foreach (char i in textIngave.ToCharArray())
            {
                if (!char.IsDigit(i))
                {
                    return true;
                }
            }
            if (textIngave.Length != 10)
            {

                return true;
            }
            return false;
        }

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
            if (foutTelefoonnummer(textBoxTelefoon.Text))
            {
                MessageBox.Show("Telefoonnummer bevat enkel cijfers en is 10 cijfers lang, startende met 047XXXXXXX");
                return;
            }
            selectedKlant.Voornaam = textBoxVoornaam.Text;
            selectedKlant.Achternaam = textBoxAchternaam.Text;
            selectedKlant.Telefoonnummer = 0 + int.Parse(textBoxTelefoon.Text);
            selectedKlant.Adres = textBoxAdres.Text;  //geen restricites op adres, niet verplicht
            klantenRepository.Opslaan(selectedKlant);
            MessageBox.Show("Dierenarts: " + selectedKlant.ToString() + " werd geupdated");
        }

        private void buttonVoegToe_Click(object sender, EventArgs e)
        {
            if (textBoxVoornaamNieuwe.Text == null || textBoxVoornaamNieuwe.Text == "")
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
            
            string voornaam = textBoxVoornaamNieuwe.Text;
            string achternaam = textBoxAchternaamNieuwe.Text;
            int telefoonnummer = 0 + Int32.Parse(textBoxTelefoonNieuwe.Text);
            string adres = textBoxAdresNieuwe.Text;
            Klant nieuweKlant = new Klant(voornaam, achternaam, telefoonnummer);
            nieuweKlant.Adres = adres;
            klantenRepository.Opslaan(nieuweKlant);
            MessageBox.Show("Klant: " + nieuweKlant.ToString() + " werd toegevoegd");
            textBoxVoornaamNieuwe.Text = "";
            textBoxAchternaamNieuwe.Text = "";
            textBoxTelefoonNieuwe.Text = "";
            textBoxAdresNieuwe.Text = "";
        }
    }
}
