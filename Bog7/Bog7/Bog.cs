using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bog7
{
    internal class Bog
    {
        string title {  get; set; }
        int antalSider {  get; set; }
        int bogId {  get; set; }

        public Bog(string title, int antalSider, int bogId)
        {
            this.title = title;
            this.antalSider = antalSider;
            this.bogId = bogId;
        }
    }
}
