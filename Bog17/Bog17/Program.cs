using System;

namespace Bog17
{
    delegate int MyDelegate(int p, int q);

    class Program
    {
        static void Main()
        {
            MyDelegate arithMethod = delegate (int c, int d)
            {
                return c > d ? c : d;
            };

            Console.WriteLine("Det største af tallene er: {0}", arithMethod(3, 7));
        }
    }
}
