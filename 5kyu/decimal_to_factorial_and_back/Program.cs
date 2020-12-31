using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    decimal_to_factorial_and_back
*/
namespace decimal_to_factorial_and_back
{
    class Program
    {
        static void Main(string[] args)
        {
            string factorial = dec2FactString(36288000);
            Console.WriteLine(factorial);

            long factorialLong = factString2Dec(factorial);
            Console.WriteLine(factorialLong);
            Console.ReadKey();
        }

    /*
        Coding decimal numbers with factorials is a way of writing out numbers in a base system that depends on factorials, rather than powers of numbers.
        In this system, the last digit is always 0 and is in base 0!. The digit before that is either 0 or 1 and is in base 1!. The digit before that is either 0, 1, or 2 and is in base 2!, etc. More generally, the nth-to-last digit is always 0, 1, 2, ..., n and is in base n!.
        Read more about it at: http://en.wikipedia.org/wiki/Factorial_number_system    
    */
        public static string dec2FactString(long nb)
        {
            string sb = "";
            int counter = 1;
            char c;
            while (true) {
                if (nb / counter == 0) {
                    var res1 = nb % counter;
                    c = (char)(res1 + 55);
                    sb += (res1 > 9) ? c.ToString() : res1.ToString();
                    break;
                }
                var res2 = nb % counter;
                c = (char)(res2 + 55);
                sb+=(res2 > 9) ? c.ToString() : res2.ToString();
                nb = nb / counter;
                counter++;
            }
            return string.Join("", sb.ToCharArray().Reverse());
        }

        public static long factString2Dec(string str)
        {
            long sum = 0;
            long longOut = 0;
            int strLen = str.Length;
            for (int i = 0, j = strLen-1; i < str.Length; i++, j--)
            {
                if (char.IsLetter(str[j]))
                {
                    var v = (int)str[j] - 55;
                    var res = v * fact(i);
                    sum += res;
                }
                else {
                    bool isValid = long.TryParse(str[j].ToString(), out longOut);
                    if (isValid)
                    {
                        var res = longOut * fact(i);
                        sum += res;
                    }
                }
            }
            return sum;
        }

        public static long fact(long l) {
            if (l == 0) return 0;
            long s = 1;
            for (long i = l; i > 0; i--)
            {
                s *= i;
            }
            return s;
        }
  }
}
