using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    internal class Dierenarts:Persoon
    {
        public SpecialisatieType Specialisatie {  get; set; }

        public Dierenarts(string voornaam, string achternaam, int telefoonnummer, SpecialisatieType specialisatie) : base(voornaam, achternaam, telefoonnummer)
        {
            this.Specialisatie = specialisatie;
        }

        public override string ToString()
        {
            return base.ToString() + " , specialisatie: " + this.Specialisatie;
        }
    }


    public enum SpecialisatieType
    {
        KattenEnHonden,
        Reptielen,
        Vogels,
        Knaagdieren
    }

  
}
