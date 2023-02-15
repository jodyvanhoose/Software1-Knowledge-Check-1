using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    // Get user input for two numbers
                    (var number1, var number2) = calculator.InputNumbers("add");

                    // If valid numbers do addition calculation
                    if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
                    {
                        Console.Write($"{number1} + {number2} = ");
                        Console.Write(calculator.Add(numOne, numTwo));
                    }
                    else
                    {
                        // Error msg if not a valid number
                        calculator.NotInt();
                    }
                    break;

                case "2":
                    // Get user input for two numbers
                    (number1, number2) = calculator.InputNumbers("subtract");

                    // If valid numbers do subtraction calculation
                    if (int.TryParse(number1, out numOne) && int.TryParse(number2, out numTwo))
                    {
                        Console.Write($"{number1} - {number2} = ");
                        Console.Write(calculator.Subtract(numOne, numTwo));
                    }
                    else
                    {
                        // Error msg if not a valid number
                        calculator.NotInt();
                    }
                    break;

                case "3":
                    // Get user input for two numbers
                    (number1, number2) = calculator.InputNumbers("multiply");

                    // If valid numbers do muliplication calculation
                    if (int.TryParse(number1, out int timesNumOne) && int.TryParse(number2, out int timesNumTwo))
                    {
                        Console.Write($"{number1} * {number2} = ");
                        Console.Write(calculator.Multiply(timesNumOne, timesNumTwo));
                    }
                    else
                    {
                        // Error msg if not a valid number
                        calculator.NotInt();
                    }
                    break;

                case "4":
                    // Get user input for two numbers
                    (number1, number2) = calculator.InputNumbers("divide");

                    // If valid numbers do division calculation
                    if (double.TryParse(number1, out double divNumOne) && double.TryParse(number2, out double divNumTwo))
                    {
                        Console.Write($"{number1} / {number2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        // Error msg if not a valid number
                        calculator.NotInt();
                    }
                    break;
                    
                    // Error msg if not 1, 2, 3, or 4 input
                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}