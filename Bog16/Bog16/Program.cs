namespace Bog16
{
    public delegate int CalculatorDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            CalculatorDelegate calculator = null;

            Console.WriteLine("Vælg operation:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    calculator = Add;
                    break;
                case "2":
                    calculator = Sub;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    return;
            }

            Console.WriteLine("Indtast første tal:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int resultat = calculator(tal1, tal2);
            Console.WriteLine($"Resultat: {resultat}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
