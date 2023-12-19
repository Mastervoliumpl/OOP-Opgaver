namespace Bog5
{
    internal class Program
    {
        static void Main()
        {
            Bog bog = new Bog
            {
                str = "Hello",
                antalSider = 17
            };

            Boghandler handler = new Boghandler();

            handler.Sælg(bog);

            string customerName;
            string customeraddress;

            handler.Indlæs(out customerName, out customeraddress);

            Console.WriteLine("----------");
            Console.WriteLine($"Kundes navn: {customerName} | Kundes adresse: {customeraddress}");
            Console.WriteLine("----------");
            Console.WriteLine($"Title: {bog.str} | Antal sider: {bog.antalSider}");

            Console.WriteLine("---------------------------------------");
            Console.Write("Indtast en kommatal: ");
            string userinput = Console.ReadLine();
            if (double.TryParse(userinput, out double doubleValue))
            {
                Console.WriteLine($"Number could be Parsed: {doubleValue}");
            }
            else 
            {
                Console.WriteLine($"Unable to Parse number: {doubleValue}");
            }

        }
    }
}
