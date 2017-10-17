using System;

namespace fourthChallenge
{
   

        public class Program
        {
            static void Main()
            {
               
                Car dreamCar = new Car(4, 2017, "Mcleren");
                Car hateCar = new Car(4, 2013, "Prius");
                
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
}
