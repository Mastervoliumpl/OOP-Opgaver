namespace Bog15
{   
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a date that is before today's date:");
            string indtastetDato = Console.ReadLine();

            try
            {
                CheckDato(indtastetDato);
                Console.WriteLine("The entry is valid and is before today's date.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The entry is not a valid date.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CheckDato(string datoStr)
        {
            if (!DateTime.TryParse(datoStr, out DateTime indtastetDato))
            {
                throw new FormatException();
            }

            if (indtastetDato >= DateTime.Today)
            {
                throw new InvalidOperationException("The date must be before today's date.");
            }
        }
    }

}
