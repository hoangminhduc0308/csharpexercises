using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    { 
        static string input(string info)
        {
            Console.Write("Enter your " + info + ": ");
            string inp = Console.ReadLine();
            return inp;
        }

        static void display(string name, string saying) 
        {
            Console.WriteLine("<" + name + ">");
            Console.WriteLine("<" + saying + ">");
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("This program will have you entering your name and your favorite saying.");
            string name, saying;
            name = input("name");
            saying = input("favorite saying");
            Console.Write(name);
            Console.ReadKey();
        }
    }
}
