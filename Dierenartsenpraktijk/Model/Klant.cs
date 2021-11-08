using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    internal class Klant:Persoon
    {
        public Adres? Adres { get; set;  }
        public List<Dier> Huisdieren { get; set; } = new List<Dier>();

        public Klant(string voornaam, string achternaam, int telefoonnummer) : base(voornaam, achternaam, telefoonnummer)
        {
        }

        public void VoegHuisdierToe(Dier dier)
        {
            this.Huisdieren.Add(dier);
        }

        public void VerwijderHuisdier(Dier dier)
        {
            this.Huisdieren.Remove(dier);
        }

        public override string ToString()
        {
            return base.ToString() + " , huisdieren: " + this.Huisdieren;
        }
    }

    internal class Adres
    {
        private string Straatnaam {  get; set; }
        private int Huisnummer {  get; set;}
        private int Postcode {  get; set; }
        private string Stad {  get; set; }

        public Adres(string straatnaam, int huisnummer, int postcode, string stad)
        {
            this.Straatnaam = straatnaam;
            this.Huisnummer = huisnummer;
            this.Postcode = postcode;
            this.Stad = stad;
        }
    }
}
