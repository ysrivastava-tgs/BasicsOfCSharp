using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class StringProgram
    {
        public static void Do()
        {
            string mary = "Mary had a little lamb";
            Console.WriteLine($"Original String={mary}");
            Console.WriteLine($"Clone Of a String={mary.Clone()}");
            Console.WriteLine($"Compare Of Two Strings={mary.CompareTo("Mary had a big lamb")}");
            Console.WriteLine($"Characters in a string={mary.Contains("had")}");
            Console.WriteLine($"String end with={mary.EndsWith("xyz")}");
            Console.WriteLine($"All lowercase={mary.ToLower()}");
            Console.WriteLine($"All uppercase={mary.ToUpper()}");
            Console.WriteLine($"Insert string within a string={mary.Insert(4, " and Jack")}");

            String[] arr = mary.Split(" ");
            foreach(String element in arr)
                Console.WriteLine(element);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
                sb.Append(i.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}
