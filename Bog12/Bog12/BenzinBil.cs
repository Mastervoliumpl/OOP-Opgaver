using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog12
{
    public class BenzinBil : IBil
    {
        public string Farve { get; set; }
        public int Km { get; private set; }

        public BenzinBil(string farve, int km)
        {
            Farve = farve;
            Km = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine($"BenzinBil - Farve: {Farve}, Km: {Km}");
        }
    }
}
