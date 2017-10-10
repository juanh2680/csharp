using System;

namespace easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
			int userInput = Convert.ToInt16(Console.ReadLine());
			

            if(userInput < 10 )
            {
                Console.WriteLine("The number is too small");
            }
            if (userInput >= 10 )
            {
                Console.WriteLine("The number is just right");
            }

        }
    }
}
