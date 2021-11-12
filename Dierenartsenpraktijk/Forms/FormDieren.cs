using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dierenartsenpraktijk.Data:
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
    }
}
