using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog12
{
    public class DieselBil : IBil
    {
        public string Farve { get; set; }
        public int Km { get; private set; }

        public DieselBil(string farve, int km)
        {
            Farve = farve;
            Km = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine($"DieselBil - Farve: {Farve}, Km: {Km}");
        }
    }
}
