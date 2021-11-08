using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenartsenpraktijk.Model
{
    //Parent klasse Enitiy voor alle modelklassen om met Generics te kunnen werken
    internal abstract class Entity
    {
        public int? Id {  get; set; }
    }
}
