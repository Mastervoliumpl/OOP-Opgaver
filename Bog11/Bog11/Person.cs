using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog11
{
    public abstract class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int Alder { get; set; }

        public Person(string fornavn, string efternavn, int alder)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Alder = alder;
        }

        public abstract void Udskriv();
    }
}
