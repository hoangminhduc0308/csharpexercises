using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    { 
        static string Asterisks()
        {
            return "*********************************";
        }

        static string SchoolInfo()
        {
            return "Schoolname: Douglas College\nNumber of students: 20000\nSchool colors: Green and Black\nSchool location: New Westminster";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Asterisks());
            Console.WriteLine(SchoolInfo());
            Console.WriteLine(Asterisks());
            Console.ReadKey();
        }
    }
}
