using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One-dimensional array:");
            string[] classmates = { "Keith", "Candy", "Christian", "Elisha", "Mathew", "Saina" };
            Console.WriteLine("Classmates:");
            foreach (string name in classmates)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            char[,] letters = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };

            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(letters[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string message = "Good Evening Everyone!";
            Console.WriteLine("Message: " + message);

            if (message.Contains("hello"))
            {
                Console.WriteLine("The message contains 'hello'.");
            }
            else
            {
                Console.WriteLine("The message does not contain 'hello'.");
            }
            Console.ReadKey();
        }
    }
}
