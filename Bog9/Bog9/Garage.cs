using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog9
{
    public class Garage
    {
        private List<Car> carList = new List<Car>();
        public void NewCar(string brand, string model, int year)
        {
            Car carObject = new Car(brand, model, year);
            carList.Add(carObject);

        }

        public void RemoveCar(string model) 
        {
            Car carToRemove = carList.FirstOrDefault(x => x.Model == model);
            if (carToRemove != null)
            {
                Car specificCar = FindCarByModel(carToRemove.Model);
                if (specificCar != null)
                {
                    Console.WriteLine($"Removing following vehicle: {specificCar.Brand}, {specificCar.Model}, {specificCar.Year}");
                }
                carList.Remove(carToRemove);
            }
        }

        public Car FindCarByModel(string model)
        {
            foreach (Car car in carList)
            {
                if (car.Model == model)
                {
                    return car; // Return the found car
                }
            }
            return null; // Return null if no car is found
        }

        public void DisplayAllCars()
        {
            Console.WriteLine("All listed cars:");
            Console.WriteLine("{0, -10} {1, -12} {2, -5}", "Brand:", "| Model:", "| Year:");
            Console.WriteLine("---------------------------------");
            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.Brand, -10} | {car.Model, -10} | {car.Year, -5}");
            }
        }
    }
}
