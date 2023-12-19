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

            Bog bog = new Bog(title, author);
            Bog bog2 = new Bog(title, author)
            {
                title = "Test Bog Title",
                author = "Test Bog Author"
            };

            Console.WriteLine($"Title: {bog.title} | Author: {bog.author}");
            Console.WriteLine($"Title: {bog2.title} | Author: {bog2.author}");
        }
    }
}
