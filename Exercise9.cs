using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Input(out string name, out double sales)
        {
            Console.Write("Enter employee name: ");
            name = Console.ReadLine();
            Console.Write("Enter sales amount: ");
            sales = Convert.ToDouble(Console.ReadLine());
        }

        static void Calculate(ref double sales, out double commission, out double federal_tax, out double retirement, out double social_security_tax)
        {
            double comm = 0.07;
            double ft_rate = 0.18, r_contrib= 0.15, ss_rate= 0.09;
            commission = sales * comm;
            federal_tax = sales * ft_rate;
            retirement = sales * r_contrib;
            social_security_tax = sales * ss_rate;
        }

        static void PrintRates(ref string name, ref double sales, ref double commission, 
                               ref double federal_tax, ref double retirement, ref double social_security_tax)
        {
            Console.WriteLine($"Employee name:           {name}");
            Console.WriteLine($"Sales:                   ${sales:f2}");
            Console.WriteLine($"Commission:              ${commission:f2}");
            Console.WriteLine($"Federal tax:             ${federal_tax:f2}");
            Console.WriteLine($"Retirement Contribution: ${retirement:f2}");
            Console.WriteLine($"Social Security Tax:     ${social_security_tax:f2}");
            Console.WriteLine($"Total:                   ${(sales + commission - federal_tax - retirement - social_security_tax):f2}");
        }
        
        static void Main(string[] args) 
        {
            string name;
            double sales, commission, federal_tax, retirement, social_security_tax;
            Input(out name, out sales);
            Calculate(ref sales, out commission, out federal_tax, out retirement, out social_security_tax);
            PrintRates(ref name, ref sales, ref commission, ref federal_tax, ref retirement, ref social_security_tax);
            Console.ReadKey();
            

        }
    }
}
