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
        static void EnterMetric(out double met)
        {
            Console.Write("Enter amount of meters to convert: ");
            met = Convert.ToDouble(Console.ReadLine());
        }

        static void ConvertToFeetAndInches(ref double meters, out double feet, out double inches)
        {
            //1m = 100cm
            //1ft = 30.48cm
            //number of feet = number of meters * 100 / 30.48
            feet = (int)(meters * 100 / 30.48);
            inches = (100.0 * meters - 30.24 * feet) / 2.54;
        }

        static void PrintFeetAndInches(ref double feet, ref double inches)
        {
            Console.WriteLine($"Number of feet: {feet:f2}");
            Console.WriteLine($"Number of inches: {inches:f2}");
        }

        static void Main(string[] args) 
        {
            double met, feet, inches;
            EnterMetric(out met);
            ConvertToFeetAndInches(ref met, out feet, out inches);
            PrintFeetAndInches(ref feet, ref inches);
            Console.ReadKey();
        }
    }
}
