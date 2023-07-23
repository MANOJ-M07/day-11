using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    internal class Program
    {
       
        
             public static long CalculateFactorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalculateFactorial(n - 1);
                }
            }
            static void Main(string[] args)
            {
                Console.Write("Enter a positive integer: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Factorial is not defined for negative numbers.");
                }
                else
                {
                    long factorial = CalculateFactorial(num);
                    Console.WriteLine($"Factorial of {num} is: {factorial}");
                }
                Console.ReadKey();
            }

    }
}

