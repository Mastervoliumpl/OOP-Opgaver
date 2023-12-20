namespace Bog13
{
    class Program
    {
        static void Main()
        {
            // Oprettelse af en bil med new
            Bil bil1 = new Bil("Blue", 50000, 150);
            bil1.Udskriv();

            Bil bil2 = new Bil { Farve = "Orange", Km = 25000, Hk = 100 };
            bil2.Udskriv();

            Bil bil3 = bil2;
            bil3.Farve = "Yellow";

            bil2.Udskriv();
            bil3.Udskriv();
        }
    }
}
