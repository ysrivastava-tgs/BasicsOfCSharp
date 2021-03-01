using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class FlowControl
    {
        public static void Do()
        {
            var a = 100;
            Console.WriteLine("================If else================");
            if (a == 100)
                Console.WriteLine("Value of a is 100");
            else if (a == 200)
                Console.WriteLine("Value of a is 200");
            else
                Console.WriteLine("Value of a is not 100 and 200");
            DoLoops();
        }
        public static void DoLoops()
        {
            var counter = 0;
            Console.WriteLine("================While================");
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter += 1;
            }
            
            Console.WriteLine("================For================");
            for (int i = counter; i < 20; i++)
                Console.WriteLine(i);
            Console.WriteLine("================Do While================");
            do
            {
                Console.WriteLine(counter);
                counter += 1;
            } while (counter < 30);

            Console.WriteLine("================For Each================");
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            foreach(var element in arr)
                Console.WriteLine(element);
        }
    }
}
