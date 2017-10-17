using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {
        static void Main()
        {
        Dictionary<string, int> roadtohire = new Dictionary<string, int>
        {
            { "Juan", 19 },
            { "Chris", 21 },
            { "Britanny", 23 },
            { "Mickey", 19},
            { "Ian", 20},
            { "Ivan", 18},
            { "Lesly", 18},
            { "Victoria", 23},
            { "Tea", 23},
            { "Markus", 18},
            { "Miguel", 21},
            { "Angel", 19},
            { "Hunter", 19},
            { "Malik", 21},
            { "Josh", 30}
        };
        roadtohire.Remove("Josh");
         int count = roadtohire.Count;
        int userIDFromDictionaryByKey = roadtohire["Juan"];
       
        Console.WriteLine(userIDFromDictionaryByKey);
       
            Console.WriteLine("Name: {0}, Age: {1}",
                           roadtohire.Keys.ElementAt(0),
                             roadtohire.Values.ElementAt(0));
            


                  
    }

  
}

