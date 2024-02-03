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
            Console.Write("Enter temperature in Farenheit: ");
            double ftemp = Convert.ToDouble(Console.ReadLine());
            double ctemp = (ftemp - 32) * 5 / 9;
            Console.WriteLine($"Original temperature in Farenheit: {ftemp:f2}");
            Console.WriteLine($"Equivalent temperature in Celcius: {ctemp:f2}");
            
            Console.ReadKey();
        }
    }
}
