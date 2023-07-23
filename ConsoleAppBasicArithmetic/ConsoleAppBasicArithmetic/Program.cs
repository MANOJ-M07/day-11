using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasicArithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            
            int sum = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

            
            int difference = num1 - num2;
            Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

            
            int product = num1 * num2;
            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

            
            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                Console.WriteLine($"Division: {num1} / {num2} = {division}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

           
            if (num2 != 0)
            {
                int remainder = num1 % num2;
                Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");
            }
            else
            {
                Console.WriteLine("Modulus by zero is not allowed.");
            }

            Console.ReadKey();  
        }
    }
}
