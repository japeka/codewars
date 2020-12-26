using System;
/*
Code wars
Level: 6kyu
Description:
    sum_of_digits
*/
namespace sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of digits");
            int v = DigitalRoot(456);
            Console.WriteLine(v);
            Console.ReadKey();
        }

        /*
        Given n, take the sum of the digits of n. If that value has more than one digit, 
        continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.  
        */  
        public int DigitalRoot(long n)
        {
            string nStr = n.ToString();
            long tempSum = 0; int i = 0;
            for (i = 0; i < nStr.Length; i++)
            {
                tempSum += long.Parse(nStr[i].ToString());
                if ((nStr.Length) - 1 == i && tempSum >= 10 )
                {
                    i = -1;
                    nStr = tempSum.ToString();
                    tempSum = 0;
                }
            }
            return (tempSum < 10) ? (int) tempSum : 0;                
        }
    }
}
