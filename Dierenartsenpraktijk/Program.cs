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
            //Klant klant = new Klant("Shana", "Donta", 03259647);
            //klant.Adres = "Kerkweg 16, Aalst";
            //KlantRepository klantRepository = new KlantRepository();
            //klantRepository.Opslaan(klant);

            //DateTime dateTime = new DateTime(2019,11,13);
            //Dier dier = new Dier("Fifi", "Hond", "bruin", dateTime, klant);
            //dier.Ras = "Labrador";
            //dier.Gezondheidsstatus = "Huidallergie";
            //DierRepository dierRepository = new DierRepository();
            //dierRepository.Opslaan(dier);

            //SpecialisatieType specialisatie = new SpecialisatieType();
            //specialisatie = SpecialisatieType.KattenEnHonden;
            //Dierenarts dierenarts = new Dierenarts("Ellen", "Mignon", 1458686, specialisatie);
            //DierenartsRepository dierenartsRepository = new DierenartsRepository();
            //dierenarts.Id = 22;
            //dierenartsRepository.Opslaan(dierenarts);

            //DateTime dateTime2 = new DateTime(2021, 11, 16, 17, 55, 00);
            //RedenAfspraak reden = RedenAfspraak.Ophalen;
            //Afspraak afspraak = new Afspraak(dateTime2, dierenarts, klant, dier, reden);
            //AfspraakRepository afspraakRepository = new AfspraakRepository();
            //afspraak.Id = 1;
            //afspraakRepository.Opslaan(afspraak);





            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
