using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicsOfCSharp
{
    class FileProgram
    {
        public static void Do()
        {
            //WriteText();
            //ReadText();
            //WriteLine();
            // ReadLine();
            Delete();
        }
        /// <summary>
        /// deleting file
        /// </summary>
        private static void Delete()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\dataLine.txt";
            File.Delete(path);
            if (!File.Exists(path))
                Console.WriteLine("File don't exist");
            else
                Console.WriteLine("File exist");
        }
        /// <summary>
        /// Writing to the file line by line 
        /// </summary>
        private static void WriteLine()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\dataLine.txt";
            if (!File.Exists(path))
                Console.WriteLine("File don't exist");
            else
                Console.WriteLine("File exist");

            StreamWriter writer = File.CreateText(path);
            writer.WriteLine("This is line one");
            writer.WriteLine("This is line two");
            writer.WriteLine("This is line three");
            writer.WriteLine("This is line four");
            writer.Close();
        }
        /// <summary>
        /// Reading file line by line
        /// </summary>
        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\dataLine.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
                var contents = File.ReadAllLines(path);
                foreach (var content in contents)
                    Console.WriteLine(content);
            }
            else
                Console.WriteLine("File dont exist");
        }
        /// <summary>
        /// Wrtiing into file in a single string
        /// </summary>
        private static void WriteText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
                Console.WriteLine("File don't exist");
            else
                Console.WriteLine("File exist");
            string content = "This is a test content";
            File.WriteAllText(filename, content);
        }
        /// <summary>
        /// Reading a file in a single string
        /// </summary>
        private static void ReadText()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\Content.txt";
            Console.WriteLine(path);
            if (!File.Exists(path))
                Console.WriteLine("File don't exist");
            else
                Console.WriteLine("File exist");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);

        }
    }
}
