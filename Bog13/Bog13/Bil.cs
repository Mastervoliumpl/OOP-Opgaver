using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog13
{
    public struct Bil
    {
        public int Km;
        public int Hk;
        public string Farve;
        

        public Bil(string farve, int km, int hk)
        {
            Km = km;
            Hk = hk;
            Farve = farve;
        }

        public void Udskriv()
        {
            Console.WriteLine($"Farve: {Farve}, Km: {Km}, HK: {Hk}");
        }
    }
}
