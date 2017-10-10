using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int frequency = 10000;
            int duration = 100;
            Console.WriteLine("Use keybpars arrows to adjudy frequency and duration");
            do
            {
                while(!Console.KeyAvailable)
                {
                    Console.Beep(frequency,duration);
                }
                {
                var key = Console.ReadKey(true);
                switch (key.Key)]

                case ConsoleKey.UpArrow;
                    frequency += 100;
                    frequency = Math.Min(frequency, 10000);
                    break; 
                     case ConsoleKey.DownArrow;
					frequency += 100;
					frequency = Math.Max(frequency, 10000);
					break;
				 case ConsoleKey.UpArrow;
					frequency += 100;
					frequency = Math.Min(frequency, 10000);
					break;
                     case ConsoleKey.UpArrow;
					frequency += 100;
					frequency = Math.Min(frequency, 10000);
					break;
				}
        }

    }
}

