using System;


namespace Bog2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();

            Bog bog = new Bog
            {
                title = title,
                author = author
            };

            Bog bog2 = new Bog
            {
                title = "Test Bog Title",
                author = "Test Bog Author"
            };

            Bog bog3 = new Bog("#2 Bog Title Test", "#2 Author");

            Console.WriteLine($"Title: {bog.title} | Author: {bog.author}");
            Console.WriteLine($"Title: {bog2.title} | Author: {bog2.author}");
            Console.WriteLine($"Title: {bog3.title} | Author: {bog3.author}");
        }
    }
}
