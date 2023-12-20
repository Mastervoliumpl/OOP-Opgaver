namespace Bog7
{
    internal class Program
    {
        static void Main()
        {
            Forlag forlag = new Forlag();

            Bog bog1 = new Bog("Bog1", 100);
            Bog bog2 = new Bog("Bog2", 150);
            Bog bog3 = new Bog("Bog3", 200);

            forlag.ModtagBog(bog1);
            forlag.ModtagBog(bog2);
            forlag.ModtagBog(bog3);
        }
    }
}
