using System;

namespace secondChallenge
{
    public class Program
    {
        static void Main()
        {
            Car car1 = new Car(4, 2017, "Civic");
            Car car2 = new Car(4, 2017, "Camry");
            Car car3 = new Car(4, 2017, "Cruze");
        }
    }
    public class Car
    {
        public int NumberOfTires { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Car(int numOfTires, int year, string model)
        {
            NumberOfTires = numOfTires;
            Year = year;
            Model = model;
        }
    }
}

