using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the length for Side1");
            var input1 = Console.ReadLine();
            double lenA = 0.0;
            double lenB = 0.0;
            double lenC= 0.0;
            while (!double.TryParse(input1, out lenA))
            {
                Console.WriteLine("Invalid Input..Please enter the length for Side1");
                input1 = Console.ReadLine();
            }
            Console.WriteLine("Please enter the length for Side2");
            var input2 = Console.ReadLine();
            while (!double.TryParse(input2, out lenB))
            {
                Console.WriteLine("Invalid Input..Please enter the length for Side2");
                input2 = Console.ReadLine();
            }
            Console.WriteLine("Please enter the length for Side3");
            var input3 = Console.ReadLine();
            while (!double.TryParse(input3, out lenC))
            {
                Console.WriteLine("Invalid Input..Please enter the length for Side3");
                input3 = Console.ReadLine();
            }
            Console.WriteLine(TriangleHelper.GetTriangleType(lenA, lenB, lenC));

            Console.Read();
        }
    }
}
