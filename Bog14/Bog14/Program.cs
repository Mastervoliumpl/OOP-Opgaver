namespace Bog14
{
    public enum Colors
    {
        Purple,
        Green,
        Yellow,
        Blue,
        Red
    }

    class Program
    {
        static void Main()
        {
            Colors myColor = Colors.Blue;
            Udskriv(myColor);
        }

        static void Udskriv(Colors color)
        {
            Console.WriteLine($"Chosen color: {color}");
        }
    }
}
