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
            SpecialisatieType type = SpecialisatieType.KattenEnHonden;
            Dierenarts dierenarts = new Dierenarts("Frida", "Goossens", 0123456789, type);
            DierenartsRepository dierenartsRepository = new DierenartsRepository();
            dierenarts.Voornaam = "Flor";
            dierenartsRepository.Opslaan(dierenarts);
            dierenarts.Voornaam = "Fidi";
            dierenartsRepository.Opslaan(dierenarts);
            dierenarts.Id = 3;
            dierenartsRepository.Delete(dierenarts);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
