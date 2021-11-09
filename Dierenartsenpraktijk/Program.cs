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
            dierenartsRepository.Opslaan(dierenarts);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
