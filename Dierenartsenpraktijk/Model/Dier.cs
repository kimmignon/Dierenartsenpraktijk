using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    internal class Dier : Entity
    {
        public string Naam {  get; set; }
        public string Soort {  get; set;}
        public string? Ras {  get; set; }
        public string Kleur {  get; set; }
        public DateOnly Geboortedatum { get; set; }
        public string? Gezondheidsstatus { get; set; }
        public Klant Baasje {  get; set; }

        public Dier(string naam, string soort, string kleur, DateOnly datum, Klant baasje)
        {
            this.Naam = naam;
            this.Soort = soort;
            this.Kleur = kleur;
            this.Geboortedatum = datum;
            this.Baasje = baasje;
        }

        public override string ToString()
        {
            if(this.Ras == null)
            {
                return this.Naam + ", soort: " + this.Soort + ", ras: /, kleur: " + this.Kleur + ", geboortedatum" +
                this.Geboortedatum + ", gezondheidsstatus: " + this.Gezondheidsstatus;
            }
            return this.Naam + ", soort: " + this.Soort + ",ras: " + this.Ras + ", kleur: " + this.Kleur + ", geboortedatum" +
                this.Geboortedatum + ", gezondheidsstatus: " + this.Gezondheidsstatus;
        }
    }

}
