using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameisrunning = false;
            int guesses = 0;
            while (!gameisrunning)
            {
                try
                {
					guesses++;
                    int userInput = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter your guess for the guessing game. Please?");
                    Random random = new Random();
                    int randomNumber = random.Next(1, 20);
                    if (randomNumber == userInput)
                    {
                        Console.WriteLine("Horray, you won! with " + " " + guesses);

                        gameisrunning = true;
                    }
                    else if (userInput > randomNumber)
                    {
                        Console.WriteLine("Your number was way too high");

                    }
                    else if (userInput < randomNumber)
                    {
                        Console.WriteLine("Your number was way too low");


                    }
                  
                }





                catch (Exception)
                {
                    Console.WriteLine("You must enter a valid number;");
                }


            }
        }
    }
}
