using System;
using TabataTimer.Models;

namespace TabataTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make our application dynamic
           Console.WriteLine("How many sets would you like to complete?");
            int sets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many seconds would you like your session to be?");
			int work = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How many second would you like your rest secction to be ");
			int rest = Convert.ToInt32(Console.ReadLine());
            // Pass in our useer input which we've mdade dynamic
            // instaniate our TabataSession model, create a TabataSession objecy
            TabataSession session = new TabataSession(sets, work, sets);
    


        }
    }
}
