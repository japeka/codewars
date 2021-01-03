using System;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    factorial_decomposition
*/
namespace factorial_decomposition
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Decomp(3000);
            Console.WriteLine(s);
            Console.ReadKey();
        }

        /*
        The aim of the kata is to decompose n! (factorial n) into its prime factors.
        Prime numbers should be in increasing order. When the exponent of a prime is 1 don't put the exponent.
        */
        public static string Decomp(int n)
        {
                IDictionary<int, int> result = new Dictionary<int, int>();
                int index = 2;
                for (index = 2; index <= n; index++)
                {
                    var number = index;
                    var numberIndex = 2;
                    if (!isPrime(number))
                    {
                        while (!isPrime(number)) {
                            if (number % numberIndex == 0)
                            {
                                if (result.ContainsKey(numberIndex))
                                {
                                    result[numberIndex] += 1; 
                                }
                                else
                                {
                                    result.Add(numberIndex, 1);
                                }
                                number = (int)(number/numberIndex);
                            }
                            else
                            {
                                numberIndex += 1; 
                            }
                        }

                        if (result.ContainsKey(number))
                        {
                            result[number] += 1;
                        }
                        else
                        {
                            result.Add(number, 1);
                        }
                    }
                    if (isPrime(index))
                    {
                        if (result.ContainsKey(index))
                        {
                            result[index] += 1;
                        }
                        else
                        {
                            result.Add(index, 1);
                        }
                    }
                }
                string output = "";
                foreach (var item in result)
                {
                    if (item.Key == 1) continue;
                    if (item.Value == 1)
                    {
                        output += item.Key + " * ";
                        continue;
                    }
                    output += item.Key + "^" + item.Value + " * ";
                }
                output = output.Length > 0 ? output.Substring(0, output.Length - 3) : "";
                return output;
        }

        static bool isPrime(int number)
        {
            var count = (int)Math.Ceiling(Math.Sqrt((double)number));
            for (var i = 2; i <=count; i++) {
                if (number % i == 0) {
                return false;
                }
            }
            return true;
        }
   }
}
