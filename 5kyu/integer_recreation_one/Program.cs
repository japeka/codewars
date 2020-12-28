using System;
/*
Code wars
Level: 5kyu
Description:
    integer recreation one
*/
namespace integer_recreation_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("integer_recreation_one");
            Console.WriteLine(listSquared(1, 250));
            Console.ReadKey();
        }

        /*  
        Divisors of 42 are : 1, 2, 3, 6, 7, 14, 21, 42. These divisors squared are: 1, 4, 9, 36, 49, 196, 441, 1764. The sum of the squared divisors is 2500 which is 50 * 50, a square!
        Given two integers m, n (1 <= m <= n) we want to find all integers between m and n whose sum of squared divisors is itself a square. 42 is such a number.
        The result will be an array of arrays or of tuples (in C an array of Pair) or a string, each subarray having two elements, first the number whose squared divisors is a square and then the sum of the squared divisors.
        */

 public static string listSquared(long m, long n)
  {
       if (m >= 1 && n >= m)
       {
                string output = "";
                for (long i = m; i < n; i++)
                {
                    long[] divisors = findDivisors(i);
                    long sum = findSquaredSum(divisors);
                    double sqrt = Math.Sqrt(sum);
                    if (sqrt % (int)sqrt == 0) {
                        output+=$"[{i}, {sum}], ";
                    }
                }
                if (output.Length > 0) {
                    output = output.Remove(output.Length - 2);
                    return $"[{output}]";
                }
        }
        return "[]";
  }
  
  static long findSquaredSum(long[] divisors) {
      long sum = divisors.Sum(s => s * s);
      return sum;
  }

  static long[] findDivisors(long num) {
      List<long> ds = new List<long>();
      for (long j = 1, k=0; j <= num; j++,k++)
      {
        if (num % j == 0) {
         ds.Add(j);
        }
      }
      return ds.ToArray();
  }        

    }
}
