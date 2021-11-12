using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dierenartsenpraktijk.Model;
using Dierenartsenpraktijk.Data;

namespace Dierenartsenpraktijk
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Wegens onbekende fout worden nooit de eerste rijen van de databse gegeven, daarom start het programma met het aanmaken van fake objecten
            //in de database. Dit is nogal omslachting, maar vond de reden niet waarom de eerste rijden niet worden geselecteerd
            Dierenarts fakeArts = new Dierenarts("Niets", "Niets", 1111111111, SpecialisatieType.KattenEnHonden);
            fakeArts.Id = 1;
            DierenartsRepository dierenartsRepository= new DierenartsRepository();
            dierenartsRepository.Opslaan(fakeArts);

            Klant fakeKlant = new Klant("Niets", "Niets", 000000);
            fakeKlant.Id = 1;
            KlantRepository klantRepository = new KlantRepository();
            klantRepository.Opslaan(fakeKlant);

            Dier fakeDier = new Dier("Niets", "Niets", "Niets", new DateTime(1753, 11, 11), fakeKlant);
            fakeDier.Id = 1;
            DierRepository dierRepository = new DierRepository();
            dierRepository.Opslaan(fakeDier);

           
            Afspraak fakeAfspraak = new Afspraak(new DateTime(1753, 11, 11), fakeArts, fakeKlant, fakeDier, RedenAfspraak.Consult);
            fakeAfspraak.Id = 1;
            AfspraakRepository afspraakRepository= new AfspraakRepository();
            afspraakRepository.Opslaan(fakeAfspraak);


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
