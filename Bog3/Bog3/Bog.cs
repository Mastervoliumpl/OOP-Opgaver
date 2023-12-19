using System;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Bog2
{
    class Bog
    {
        public string title { get; set; }
        public string author { get; set; }

        public Bog() { }

        public Bog(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
