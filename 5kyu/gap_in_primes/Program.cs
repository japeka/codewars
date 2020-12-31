using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    gap_in_primes
*/
namespace gap_in_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Gap(10, 300, 400)));
            Console.ReadKey();
        }

    /*
        The prime numbers are not regularly spaced. For example from 2 to 3 the gap is 1. From 3 to 5 the gap is 2. From 7 to 11 it is 4. Between 2 and 50 we have the following pairs of 2-gaps primes: 3-5, 5-7, 11-13, 17-19, 29-31, 41-43
        A prime gap of length n is a run of n-1 consecutive composite numbers between two successive primes (see: http://mathworld.wolfram.com/PrimeGaps.html).
    */
    public static long[] Gap(int g, long m, long n) 
    {
        if (g >= 2 && m > 2 && n >= m) { 
           var primeFound = false;
           var primeValue = 0L;
           for (long i = m; i <= n; i++)
           {
             if (IsPrime(i)) {
               if (primeFound) {
                 var gap = i - primeValue;
                    if (gap == g) {
                     return new long[] {primeValue, i };
                    }
                 }
               primeFound = true;
               primeValue = i;
             }
          }
        }
        return null;
    }
  
    public static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
  }
}
