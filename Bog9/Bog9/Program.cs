namespace Bog9
{
    internal class Program
    {
        static void Main()
        {
            Garage garage = new Garage();
            garage.NewCar("Toyota", "Camry", 2021);
            garage.NewCar("Tesla", "Model S", 2022);
            garage.NewCar("BMW", "M4", 2020);
            garage.NewCar("Volkswagen", "Passat", 2022);


            Console.Write("Search for vehicle by Model (Case Sensitive): ");
            string userSpecifiedModel = Console.ReadLine();

            Car specificCar = garage.FindCarByModel(userSpecifiedModel);
            if (specificCar != null)
            {
                Console.WriteLine($"Found Car: {specificCar.Brand}, {specificCar.Model}, {specificCar.Year}");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }

            Console.WriteLine("--------------------------");

            // Display all cars
            garage.DisplayAllCars();
            Console.WriteLine("--------------------------");

            Console.Write("Remove vehicle by Model (Case Sensitive): ");
            string userSpecifiedModelToRemove = Console.ReadLine();

            garage.RemoveCar(userSpecifiedModelToRemove);
            Console.WriteLine("--------------------------");

            garage.DisplayAllCars();
        }
    }
}
