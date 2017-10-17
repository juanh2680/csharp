using System;

namespace veryhard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What number would you like to convert?.");
			int userNumber = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("What type of converstion would you like to do?." +
           "\nI -> convert from inches to centimeters. \nG -> convert from gallons to liters." +
           "\u202f \nM -> convert from mile to kilometer.\u202f \nP -> convert from pound to kilogram.\u202f");
            string userInput = Console.ReadLine();
			switch (userInput.ToLower())
			{
				case ("i"):
                    double inchTocm = userNumber * 2.54;
					Console.WriteLine(inchTocm);
					break;
				case ("g"):
                    double gallonTolitters = userNumber * 3.7854;
					Console.WriteLine(gallonTolitters);
					break;
				case ("m"):
                    double mileTokilometer = userNumber * 1.609344;
                    Console.WriteLine(mileTokilometer);
					break;
				case ("p"):
                    double poundsTokilos = userNumber * 0.45359237;
                    Console.WriteLine(poundsTokilos);
					break;
				default:
					Console.WriteLine("Please type the right info");
					break;
			}
        }
    }
}
