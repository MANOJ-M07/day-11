using System;

namespace ConsoleAppExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                try
                {
                    age = int.Parse(input);

                    if (age >= 0)
                    {
                        isValidInput = true;

                        if (age < 18)
                        {
                            Console.WriteLine("You are a minor.");
                        }
                        else if (age >= 18 && age < 65)
                        {
                            Console.WriteLine("You are an adult.");
                        }
                        else
                        {
                            Console.WriteLine("You are a senior.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The entered age is too large or too small.");
                }
            }
            Console.ReadKey();
        }
    }
}
