using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }


        // Error msg if an invalid input(not a number)
        public void NotInt()
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }


        // Accept user input for 2 numbers
        public (string, string) InputNumbers(string calc)
        {
            Console.WriteLine($"Enter 2 integers to {calc}");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            return (number1, number2);
        }
    }
}
