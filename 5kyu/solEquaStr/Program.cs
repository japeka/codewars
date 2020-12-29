using System;
/*
Code wars
Level: 5kyu
Description:
    solEquaStr
*/
namespace solEquaStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("solEquaStr");
            Console.WriteLine(solEquaStr(90002));
           Console.ReadKey();
        }

        /*  
            In mathematics, a Diophantine equation is a polynomial equation, usually with two or more unknowns, such that only the integer 
            solutions are sought or studied.
            In this kata we want to find all integers x, y (x >= 0, y >= 0) solutions of a diophantine equation of the form:        
        */
        public static string solEquaStr(long n) {
            string output = "";
            for (long i = 1; i < (int)Math.Sqrt(n) + 1; i++)
                if (n % i == 0)
                {
                    long j = n / i;
                    if ((i + j) % 2 == 0 && (j - i) % 4 == 0)
                    {
                        long x = (i + j) / 2;
                        long y = (j - i) / 4;
                        output += $"[{x}, {y}], ";
                    }
                }
                if (output.Length != 0)
                {
                    output = $"[{output.Remove(output.Length - 2)}]";
                }
                else {
                    output = "[]";
                }
            return $"{output}";
        }
    }
}
