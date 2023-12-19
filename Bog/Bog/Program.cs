using System.Net;

namespace Bog
{
    internal class Program
    {
        static void Main()
        {
            Bog bog = new Bog();
            Console.Write("Title: ");
            bog.title = Console.ReadLine();
            Console.Write("Author: ");
            bog.author = Console.ReadLine();

            Console.WriteLine($"Title: {bog.title} | Author: {bog.author}");
        }

        
    }
}
