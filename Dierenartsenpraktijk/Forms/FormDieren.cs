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
    public partial class FormDieren : Form
    {
        public FormDieren()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Dierrepository om mee te werken
        DierRepository dierRepository = new DierRepository();
        //attribuut om dieren in lijst op te slaan
        List<Dier> LijstDier = new List<Dier>();
        //Selected diers
        Dier selectedDier;

        //functie om lijst van dierenartsen weer te geven in listbox
        private void zetDierenInListbox(List<Dier> list)
        {

            //steeds resetten van geselecteerde arts en textboxen terug leegmaken
            selectedDier = null;
            selectedKlant = null;
            textBoxNaam.Text = "";
            textBoxSoort.Text = "";
            textBoxRas.Text = "";
            textBoxKleur.Text = "";
            textBoxStatus.Text = "";
            dateTimePickerDier.Value = new DateTime(1753,01,01);
            listBoxBaasje.Items.Clear();


            listBoxDieren.Items.Clear();
            listBoxDieren.Items.Add("-Id- \t -Naam- \t \t -Soort- \t \t -Kleur - \t \t -Baasje- \t \t \t -Geboortedatum-");
            foreach (Dier dier in list)
            {
                int? id = dier.Id;
                string naam = dier.Naam;
                string soort = dier.Soort;
                string kleur = dier.Kleur;
                string baasje = dier.Baasje.Voornaam + " " + dier.Baasje.Achternaam;
                DateTime datum = dier.Geboortedatum;

                string inputItem = id + "\t" + naam + "\t \t" + soort + "\t \t" + kleur + "\t \t" + baasje + "\t \t" + datum;
                listBoxDieren.Items.Add(inputItem);
            }
        }

        private void buttonToonAlle_Click(object sender, EventArgs e)
        {
            LijstDier = dierRepository.GeefAlle();
            zetDierenInListbox(LijstDier);
        }

        private void buttonGeefOpNaam_Click(object sender, EventArgs e)
        {
            if (textBoxGeefNaam.Text == "Geef naam in" || textBoxGeefNaam.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om dieren te zoeken");
                return;
            }
            LijstDier = dierRepository.GeefOpNaam(textBoxGeefNaam.Text);
            zetDierenInListbox(LijstDier);
        }

        private void buttonSelecteer_Click(object sender, EventArgs e)
        {
            int index = listBoxDieren.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedDier = LijstDier[index];
            labelSelectedDier.Text = "Dier " + selectedDier.Id + ":";
            textBoxNaam.Text = selectedDier.Naam;
            textBoxSoort.Text = selectedDier.Soort;
            textBoxRas.Text = selectedDier.Ras;
            textBoxKleur.Text = selectedDier.Kleur;
            textBoxStatus.Text = selectedDier.Gezondheidsstatus;
            dateTimePickerDier.Value = selectedDier.Geboortedatum;
            
            listBoxBaasje.Items.Clear();
            listBoxBaasje.Items.Add(selectedDier.Baasje.Voornaam + " " + selectedDier.Baasje.Achternaam);
            selectedKlant = selectedDier.Baasje;
        }

        //nu alles om klant te zoeken en te selecteren voor eventueel dier te updaten (dier kan namelijk van baasje veranderen)
        List<Klant> LijstKlanten = new List<Klant>();
        Klant selectedKlant;
        KlantRepository klantenRepository = new KlantRepository();
        private void zetKlantenInListbox(List<Klant> list)
        {
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken

            selectedKlant = null;
            listBoxKlanten.Items.Clear();
            listBoxKlanten.Items.Add("-Id- \t -Naam- \t \t -Telefoon-");
            foreach (Klant klant in list)
            {
                int? id = klant.Id;
                string voornaam = klant.Voornaam;
                string achternaam = klant.Achternaam;
                int telefoon = klant.Telefoonnummer;
                string inputItem = id + "\t" + voornaam + " " + achternaam + "\t" + telefoon;
                listBoxKlanten.Items.Add(inputItem);
            }
        }

        private void buttonAlleKlanten_Click(object sender, EventArgs e)
        {
            LijstKlanten = klantenRepository.GeefAlle();
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonNaamKlant_Click(object sender, EventArgs e)
        {
            if (textBoxNaamKlant.Text == "Geef naam in" || textBoxNaamKlant.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om dierenartsen te zoeken");
                return;
            }
            LijstKlanten = klantenRepository.GeefOpNaam(textBoxNaamKlant.Text);
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonSelecteerKlant_Click(object sender, EventArgs e)
        {
            if(selectedDier == null)
            {
                return;
            }
            int index = listBoxKlanten.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedKlant = LijstKlanten[index];
            selectedDier.Baasje = selectedKlant;
            listBoxBaasje.Items.Clear();
            listBoxBaasje.Items.Add(selectedDier.Baasje.Voornaam + " " + selectedDier.Baasje.Achternaam);
        }


     

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxNaam.Text == null || textBoxNaam.Text == "")
            {
                MessageBox.Show("Vul een naam in");
                return;
            }
            if (textBoxSoort.Text == null || textBoxSoort.Text == "")
            {
                MessageBox.Show("Vul een achternaam in");
                return;
            }
            if(textBoxKleur.Text == null || textBoxKleur.Text == "")
            {
                MessageBox.Show("Vul een kleur in");
                return;
            }
            selectedDier.Naam = textBoxNaam.Text;
            selectedDier.Soort = textBoxSoort.Text;
            selectedDier.Ras = textBoxRas.Text;
            selectedDier.Kleur = textBoxKleur.Text;
            selectedDier.Gezondheidsstatus = textBoxStatus.Text;
            selectedDier.Geboortedatum = dateTimePickerDier.Value;
            dierRepository.Opslaan(selectedDier);
            MessageBox.Show("Dier: " + selectedDier.ToString() + " werd geupdated");

        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            if (selectedDier == null)
            {
                return;
            }
            MessageBox.Show(selectedDier.Naam + ", " + selectedDier.Soort + " van " + selectedDier.Baasje.Voornaam + " [id: " + selectedDier.Id + "] werd verwijderd uit de database");
            dierRepository.Delete(this.selectedDier);
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken
            selectedDier = null;
            selectedKlant = null;
            textBoxNaam.Text = "";
            textBoxSoort.Text = "";
            textBoxRas.Text = "";
            textBoxKleur.Text = "";
            textBoxStatus.Text = "";
            dateTimePickerDier.Value = new DateTime(1753, 01, 01);
            listBoxBaasje.Items.Clear();
        }
    }
}
