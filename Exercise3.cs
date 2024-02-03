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
        static void EnterSides(out double width, out double height)
        {
            Console.Write("Enter width: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double b = Convert.ToDouble(Console.ReadLine());
            width = a;
            height = b;
        }

        static void Compute(double width, double height, out double area, out double perimeter)
        {
            area = width * height;
            perimeter = (width + height) * 2;
        }

        static void PrintResult(double area, double perimeter)
        {
            Console.WriteLine($"Area      : {area:f2}");
            Console.WriteLine($"Perimieter: {perimeter:f2}");
        }

        static void Main(string[] args)
        {
            double w, h, a, p;
            EnterSides(out w, out h);
            Compute(w, h, out a, out p);
            PrintResult(a, p);
            Console.ReadKey();
        }
    }
}
