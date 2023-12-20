using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog7
{
    public class Forlag
    {
        private int currentNr = 0;

        public void ModtagBog(Bog bog)
        {
            currentNr++;
            bog.Nr = currentNr;
            Console.WriteLine($"Modtaget: {bog.Titel}, Nr: {bog.Nr}");
        }
    }
}
