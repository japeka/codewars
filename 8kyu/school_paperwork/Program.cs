using System;
/*
Code wars
Level: 8kyu
Description:
    Beginner Series #1 School Paperwork & Square
*/
namespace dollars_cents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("School Paperwork, Square");
            System.Console.WriteLine(Paperwork(2,2));
            System.Console.WriteLine(Square(2));
            Console.ReadKey();
        }

        public static int Paperwork(int n, int m)
        {
            return n > 0 && m > 0 ? n * m : 0;
        }

        public static double Square(double n) => Math.Pow(n,2);
    }
}
