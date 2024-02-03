using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            double charge, tax = 0.09, tip15 = 0.15, tip20 = 0.2;
            Console.Write("Enter charge (before taxes): ");
            charge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Tax:                  ${(charge * tax):f2}");
            charge = charge * (1 + tax); //print out tax early, later than this would miscalculate
            
            Console.WriteLine($"Tip of 15%:           ${(charge * tip15):f2}");
            Console.WriteLine($"Total (with 15% tip): ${(charge * (1 + tip15)):f2}");

            Console.WriteLine($"Tip of 20%:           ${(charge * tip20):f2}");
            Console.WriteLine($"Total (with 20% tip): ${(charge * (1 + tip20)):f2}");

            Console.ReadKey();
        }
    }
}
