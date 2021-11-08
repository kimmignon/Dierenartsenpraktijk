using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    internal class Afspraak:Entity
    {
        private DateTime DatumTijdstip { get; set; }
        private Dierenarts Arts { get; set; }
        private Klant Klant {  get; set; }

        private Dier Dier {  get; set; }
        private RedenAfspraak Reden {  get; set; }

        public Afspraak ( DateTime datumTijdstip, Dierenarts arts, Klant klant, Dier dier, RedenAfspraak reden)
        {
            this.DatumTijdstip = datumTijdstip;
            this.Arts = arts;
            this.Klant = klant;
            this.Dier = dier;
            this.Reden = reden;
        }

        public override string ToString()
        {
            return "Afspraak " + this.Id + ", datum en tijdstip: " + this.DatumTijdstip + ", dierenarts: " +
                this.Arts.Voornaam + this.Arts.Achternaam + ", klant: " + this.Klant.Voornaam + this.Klant.Achternaam +
                ", dier: " + this.Dier.Naam;
        }
    }

    public enum RedenAfspraak
    {
        BinnenbrengenOperatie,
        Ophalen,
        Consult,
        Vaccinatie
    }
}
