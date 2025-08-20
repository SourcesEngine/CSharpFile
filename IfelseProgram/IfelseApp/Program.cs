using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exam_score = 75;
            if (exam_score > 90)
            {
                Console.WriteLine("The grade of the student is A.");

            }
           
            else if (exam_score > 85)
            {
                Console.WriteLine("The grade of the student is B");
            }
            else if (exam_score > 80)
            {
                Console.WriteLine("The grade of the student is C");

            }
            else if (exam_score > 75)
            {
                Console.WriteLine("The grade of the student is D");

            }
            else
            {
                Console.WriteLine("The Student failed the exam.");
            }
        }
    }
}
