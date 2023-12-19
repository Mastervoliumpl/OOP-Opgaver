namespace Bog4
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

            Console.WriteLine($"Title: {bog.str} | Antal sider: {bog.antalSider}");
        }
    }
}
