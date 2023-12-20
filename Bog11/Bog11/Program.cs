namespace Bog11
{
    class Program
    {
        static void Main()
        {
            List<Person> personer = new List<Person>
            {
                new Elev("Charlie", "Christensen", 17, 11),
                new Elev("Diana", "Davidsen", 18, 12)
            };

            foreach (Person person in personer)
            {
                person.Udskriv();
            }
        }
    }

}
