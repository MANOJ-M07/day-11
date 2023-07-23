using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            
            double average = (double)sum / numbers.Length;

            
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {average}");

            Console.ReadKey();  
        }
    }
}
