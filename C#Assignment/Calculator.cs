using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Calculator
    {
        public delegate void Calculate(int a, int b);

        public static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"Sub: {a - b}");
        }

        public static void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Divide: {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine($"Mul: {a * b}");
        }
    }
}
