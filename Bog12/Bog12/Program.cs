namespace Bog12
{
    class Program
    {
        static void Main()
        {
            BenzinBil benzinBil = new BenzinBil("Green", 100500);
            DieselBil dieselBil = new DieselBil("Orange", 255000);

            benzinBil.UdskrivBil();
            dieselBil.UdskrivBil();
        }
    }
}
