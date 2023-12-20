namespace Bog10
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Alice", 30);
            Elev elev = new Elev("Bob", 16, 10);

            person.Udskriv();
            elev.Udskriv();
        }
    }
}
