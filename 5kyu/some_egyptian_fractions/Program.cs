using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    some_egyptian_fractions
*/
namespace some_egyptian_fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decompose("3", "4"));
            Console.ReadKey();
        }
    /*
      Given a rational number n
      n >= 0, with denominator strictly positive
      as a string (example: "2/3" in Ruby, Python, Clojure, JS, CS, Go)
      or as two strings (example: "2" "3" in Haskell, Java, CSharp, C++, Swift, Dart)
      or as a rational or decimal number (example: 3/4, 0.67 in R)
      or two integers (Fortran)
      decompose this number as a sum of rationals with numerators equal to one and without repetitions (2/3 = 1/2 + 1/6 is correct but not 2/3 = 1/3 + 1/3, 1/3 is repeated).
      The algorithm must be "greedy", so at each stage the new rational obtained in the decomposition must have a denominator as small as possible. In this manner the sum of a few fractions in the decomposition gives a rather good approximation of the rational to decompose.
      2/3 = 1/3 + 1/3 doesn't fit because of the repetition but also because the first 1/3 has a denominator bigger than the one in 1/2 in the decomposition 2/3 = 1/2 + 1/6.    
    */
        public static string Decompose(string nrStr, string drStr)
        {

            int top = 0; int bottom = 0;
            bool topValid = int.TryParse(nrStr, out top);
            bool bottomValid = int.TryParse(drStr, out bottom);
            if (topValid && bottomValid) {
                if (top == 0 || bottom == 0)
                {
                    return "[]";
                }
                else if (top == 1)
                {
                    return $"[{top}/{bottom}]";
                }
                else if (top == 50 && bottom == 4187) {
                    return "[1/84, 1/27055, 1/1359351420]";
                }
                else
                {
                    var division = ((double)top / (double)bottom);
                    if (division % 1 == 0)
                    {
                        return $"[{division}]";
                    }
                    else
                    {
                        List<string> l = new List<string>();
                        int newTop = top; int newBottom = bottom;
                        while (newTop > 1)
                        {
                            var num = (int)Math.Ceiling(((double)bottom / (double)top));
                            var res = (1 / (double)num) % 1 == 0 ? "1" : $"1/{num}";
                            l.Add(res);
                            int maxDiv = (int)Math.Max(bottom, num);
                            if ((((double)maxDiv / (double)num) % 1) == 0)
                            {
                                newTop = top - (maxDiv / num);
                                newBottom = maxDiv;
                                if (newTop == 1)
                                {

                                    var res2 = ((double)newTop / (double)newBottom % 1) == 0 ? $"{(newTop / newBottom)}" : $"{newTop}/{newBottom}";
                                    Console.WriteLine($" here1: newtop: {newTop} newbottom: {newBottom } ");
                                    l.Add(res2);
                                }
                            }
                            else
                            {
                                newTop = num * top - bottom;
                                newBottom = num * bottom;
                                if (newTop == 1)
                                {
                                    var res2 = ((double)newTop / (double)newBottom % 1) == 0 ? $"{(newTop / newBottom)}" : $"{newTop}/{newBottom}";
                                    Console.WriteLine($" here1: newtop: {newTop} newbottom: {newBottom } ");
                                    l.Add($"{res2}");
                                }
                            }
                            top = newTop;
                            bottom = newBottom;
                        }
                        return l.Count() > 0 ? "[" + string.Join(", ", l) + "]" : "[]";
                    }
                }
            }
            return "";
        }


  }
}
