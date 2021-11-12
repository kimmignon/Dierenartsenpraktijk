using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    internal abstract class Persoon : Entity
    {
        public string Voornaam { get;  set; }
        public string Achternaam {  get; set; }
        public int Telefoonnummer {  get; set; }

        public Persoon(string voornaam, string achternaam, int telefoonnummer)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Telefoonnummer = telefoonnummer;
        }

        public override string ToString()
        {
            return this.Voornaam + " " + this.Achternaam + ", tel: 0" + this.Telefoonnummer;
        }
    }
}
