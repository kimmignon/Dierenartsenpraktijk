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
    public partial class FormAfspraken : Form
    {
        public FormAfspraken()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Methodes om klant te selecteren voor nieuwe afspraak
        List<Klant> LijstKlanten = new List<Klant>();
        Klant selectedKlant;
        KlantRepository klantenRepository = new KlantRepository();
        private void zetKlantenInListbox(List<Klant> list)
        {
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken
            selectedKlant = null;
            listBoxKlantNieuw.Items.Clear();
            listBoxKListNieuw.Items.Clear();
            listBoxKListNieuw.Items.Add("-Id- \t -Naam- \t \t -Telefoon-");
            foreach (Klant klant in list)
            {
                int? id = klant.Id;
                string voornaam = klant.Voornaam;
                string achternaam = klant.Achternaam;
                int telefoon = klant.Telefoonnummer;
                string inputItem = id + "\t" + voornaam + " " + achternaam + "\t" + telefoon;
                listBoxKListNieuw.Items.Add(inputItem);
            }
        }

        private void buttonAlleKN_Click(object sender, EventArgs e)
        {
            LijstKlanten = klantenRepository.GeefAlle();
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonOpNaamKN_Click(object sender, EventArgs e)
        {
            if (textBoxNaamKN.Text == "Geef naam in" || textBoxNaamKN.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om klant te zoeken");
                return;
            }
            LijstKlanten = klantenRepository.GeefOpNaam(textBoxNaamKN.Text);
            zetKlantenInListbox(LijstKlanten);
        }

        private void buttonSelKN_Click(object sender, EventArgs e)
        {
            int index = listBoxKListNieuw.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedKlant = LijstKlanten[index];
            listBoxKlantNieuw.Items.Clear();
            listBoxKlantNieuw.Items.Add(selectedKlant.Voornaam + " " + selectedKlant.Achternaam);

            klantenRepository.GeefDierenKlant(selectedKlant);
            LijstDieren = selectedKlant.Huisdieren;
            toonDierenVanKlant(LijstDieren);
        }

        //Methodes om dier te selecteren voor nieuwe afspraak
        List<Dier> LijstDieren = new List<Dier>();
        Dier selectedDier;
        DierRepository dierRepository = new DierRepository();
        private void toonDierenVanKlant(List<Dier> list)
        {
            selectedDier = null;
            listBoxDierNieuw.Items.Clear();
            listBoxDListNieuw.Items.Clear();
            listBoxDListNieuw.Items.Add("-Id- \t -Naam- \t \t -Soort-");
            foreach (Dier dier in list)
            {
                int? id = dier.Id;
                string naam = dier.Naam;
                string soort = dier.Soort;
                string inputItem = id + "\t" + naam + " \t \t" + soort;
                listBoxDListNieuw.Items.Add(inputItem);
            }
        }


        private void buttonSelDN_Click(object sender, EventArgs e)
        {
            int index = listBoxDListNieuw.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedDier = LijstDieren[index]; 
            listBoxDierNieuw.Items.Clear();
            listBoxDierNieuw.Items.Add(selectedDier.Naam + " " + selectedDier.Soort);
        }

        //methodes om arts te selecteren voor nieuwe afspraak
        List<Dierenarts> LijstArtsen = new List<Dierenarts>();
        Dierenarts selectedArts;
        DierenartsRepository artsRepository = new DierenartsRepository();
        private void zetArtsenInListbox(List<Dierenarts> list)
        {
            //steeds resetten van geselecteerde klant en textboxen terug leegmaken
            selectedKlant = null;
            listBoxArtsNieuw.Items.Clear();
            listBoxAListNieuw.Items.Clear();
            listBoxAListNieuw.Items.Add("-Id- \t -Naam-");
            foreach(Dierenarts arts in list)
            {
                int? id = arts.Id;
                string voornaam = arts.Voornaam;
                string achternaam = arts.Achternaam;
                string inputItem = id + "\t" + voornaam + " " + achternaam;
                listBoxAListNieuw.Items.Add(inputItem);
            }

        }

        private void buttonAlleAN_Click(object sender, EventArgs e)
        {
            LijstArtsen = artsRepository.GeefAlle();
            zetArtsenInListbox(LijstArtsen);
        }

        private void buttonNaamAN_Click(object sender, EventArgs e)
        {
            if (textBoxNaamAN.Text == "Geef naam in" || textBoxNaamAN.Text == "")
            {
                MessageBox.Show("Geef een naam of een deel van een naam in om dierenarts te zoeken");
                return;
            }
            LijstArtsen = artsRepository.GeefOpNaam(textBoxNaamAN.Text);
            zetArtsenInListbox(LijstArtsen);
        }

        private void buttonSelectAN_Click(object sender, EventArgs e)
        {
            int index = listBoxAListNieuw.SelectedIndex - 1;
            if (index < 0)
            {
                return;
            }
            this.selectedArts = LijstArtsen[index];
            listBoxArtsNieuw.Items.Clear();
            listBoxArtsNieuw.Items.Add(selectedArts.Voornaam + " " + selectedArts.Achternaam);
        }

        AfspraakRepository afspraakRepository = new AfspraakRepository();
        private void buttonVoegToe_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Kies een reden voor consult");
                return;
            }
            if (selectedKlant == null)
            {
                MessageBox.Show("Kies een klant waarvoor u een afspraak wilt maken");
                return;
            }
            if (selectedDier == null)
            {
                MessageBox.Show("Kies een dier waarvoor u een afspraak wilt maken");
                return;
            }
            if (selectedArts == null)
            {
                MessageBox.Show("Kies de dierenarts die verantwoordelijk is voor de afspraak");
                return;
            }
            DateTime tijdstip = dateTimePickerNieuw.Value;
        
            RedenAfspraak redenConsult = afspraakRepository.mapRedenAfspraak(comboBox1.ValueMember);


            Afspraak nieuweAfspraak = new Afspraak(tijdstip, selectedArts, selectedKlant, selectedDier, redenConsult);
            afspraakRepository.Opslaan(nieuweAfspraak);
            MessageBox.Show("Afspraak: " + nieuweAfspraak.ToString() + " werd toegevoegd");
            dateTimePickerNieuw.Value = new DateTime(1753, 01, 01, 01, 01, 01);
            listBoxKlantNieuw.Items.Clear();
            listBoxArtsNieuw.Items.Clear();
            listBoxDierNieuw.Items.Clear();
        }

        private void buttonToonAlles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Afspraak afspraak in afspraakRepository.GeefAlle())
            {
                int? id = afspraak.Id;
                string naamArts = afspraak.Arts.Voornaam + " "+ afspraak.Arts.Achternaam;
                string naamKlant = afspraak.Klant.Voornaam + " " + afspraak.Klant.Achternaam;
                string naamDier = afspraak.Dier.Naam + ", " + afspraak.Dier.Soort;
                string inputItem = id + "\t" + naamArts + "\t" + naamKlant + "\t" + naamDier;
                listBox1.Items.Add(inputItem);
            }
        }
    }
}
