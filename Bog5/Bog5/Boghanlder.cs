using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog5
{
    public class Boghandler
    {
        public void Sælg(Bog bogMethod)
        {
            bogMethod.str = "Such cool book to read you should read it is really cool I really like it and you should too.";
        }

        public void Indlæs(out string name, out string address)
        {
            Console.Write("Indtast din navn: ");
            name = Console.ReadLine();
            Console.Write("Indtast din adresse: ");
            address = Console.ReadLine();
        }
    }
}
