using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double elictric_voltz = Math.Sqrt(10);
            Console.WriteLine("The Square root of 10 voltz is "+elictric_voltz);

            double power_of_five_by_two = Math.Pow(5, 2);
            Console.WriteLine("The power of five by two is " + power_of_five_by_two);

            double roundoff = Math.Round(2.5);
            Console.WriteLine("2.5 Round off to "+ roundoff);

            double truncate = Math.Truncate(roundoff);
            Console.WriteLine("The Truncate of 2.5 is " + truncate);

            double exp = Math.Exp(10.5);
            Console.WriteLine("The Exponent of 10 is " + exp);

            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadKey();

        }
    }
}
