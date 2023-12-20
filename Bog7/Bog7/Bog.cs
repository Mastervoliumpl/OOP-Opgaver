using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bog7
{
    public class Bog
    {
        public string Titel { get; set; }
        public int AntalSider { get; set; }
        public int Nr { get; set; }

        public Bog(string titel, int antalSider)
        {
            Titel = titel;
            AntalSider = antalSider;
        }
    }
}
