using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog10
{
    public class Elev : Person
    {
        public int KlasseNr { get; set; }

        public Elev(string navn, int alder, int klasseNr) : base(navn, alder)
        {
            KlasseNr = klasseNr;
        }
    }
}
