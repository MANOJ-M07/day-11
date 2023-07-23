using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppControlStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

         
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }

            Console.ReadKey();
        }
    }
}
