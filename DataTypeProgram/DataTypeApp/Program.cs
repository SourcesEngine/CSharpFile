using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price of ViVo X200 PRO in the Philippines?: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance From Home to School?: ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Byte Number?: ");
            byte smallNumber = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Your Phone Number?: ");
            string input = Console.ReadLine();
            long phonenumber;
            if (long.TryParse(input, out phonenumber))
            {
                Console.WriteLine("\n");
                Console.WriteLine(" Your Phone number is: " + phonenumber);

            }
            else
            {
                Console.WriteLine("");
            }

            Console.WriteLine(" Year Today: " + year);
            Console.WriteLine(" Price of dream phone " + price);
            Console.WriteLine(" Distance Traveled Today : " + distance + " km");          
            Console.WriteLine(" Smallest number of Byte : " + smallNumber);

            Console.WriteLine(" Press any key to exit..");
            Console.ReadKey();

        }
    }
}
