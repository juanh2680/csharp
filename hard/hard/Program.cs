using System;

namespace hard
{
    class Program
    {
        static void Main(string[] args)
        {
			for (int i = 1; i <= 5; i++)
			{
				for (int x = i; x <= 5; x++)
				{
					//Adding space to pyramid
					Console.Write(" ");
				}
				for (int j = 1; j <= i; j++)
				{
					//Adding * symbol to pyramid
                    // Without this the input would have a triangle 
                    Console.Write("*" + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();

		}
    }
}
