//mahdieh navaeifar

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: You cannot divide a number by 0!");
                            Console.ReadLine();
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        Console.ReadLine();
                        return;
                }

                Console.WriteLine("Result: " + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}