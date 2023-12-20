using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog9
{
    public class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string brand, string model, int year) 
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public Car() { }
    }
}
