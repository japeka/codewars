using System;
/*
Code wars
Level: 8kyu
Description:
    This function takes two numbers as parameters, the first number being the coefficient, and the second number being the exponent.
    Your function should multiply the two numbers, and then subtract 1 from the exponent. Then, it has to print out an expression (like 28x^7). 
    "^1" should not be truncated when exponent = 2.
*/
namespace take_the_derivative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("take_the_derivative");
            Console.WriteLine(Derive(7, 8));
            Console.WriteLine(Derive(5, 9));
            Console.ReadKey();
        }

        public static string Derive(double coefficient, double exponent)
        {
            if (exponent == 0 || exponent == 1 || coefficient == 1) {
                return "";
            }
            return $"{coefficient*exponent}x^{exponent-1}";
        }
    }
}
