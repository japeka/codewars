using System;
/*
Code wars
Level: 7kyu
Description:
    unique_string_characters
*/
namespace unique_string_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unique string characters");
            Console.WriteLine(Solve("xyab", "xzca"));
            Console.WriteLine(Solve("xyabb", "xzca"));
            Console.WriteLine(Solve("abcd", "xyz"));
            Console.WriteLine(Solve("xxx", "xzca"));
            Console.ReadKey();
        }

        /*  
            In this Kata, you will be given two strings a and b and your task will be to return 
            the characters that are not common in the two strings.        
        */
        public static string Solve(string a, string b)
        {
            var r1 = a.ToCharArray().Where(v => !b.ToCharArray().Contains(v));
            var r2 = b.ToCharArray().Where(v => !a.ToCharArray().Contains(v));
            return $"{string.Join("", r1)}{string.Join("", r2)}";
        }

    }
}
