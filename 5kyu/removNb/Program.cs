using System;
/*
Code wars
Level: 5kyu
Description:
    removNb
*/
namespace removNb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("removNb");
            Console.WriteLine(string.Join(",", removNb(5)));
            Console.ReadKey();
        }

        /*  
		removNb
		*/
		public static List<long[]> removNb(long n)
        {
            List<long[]> r = new List<long[]>();
            long s = n * (n + 1) / 2;
            for (long a = 1; a <= n; a++)
            {
                double b = (double)(s - a) / (a + 1);
                if (b % 1 == 0 && b <= n)
                    r.Add(new long[] { a, (long)b });
            }
            return r.OrderBy(e => e[0]).ToList();
        }
    }
}
