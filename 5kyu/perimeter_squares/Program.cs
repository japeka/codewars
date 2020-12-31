using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    perimeter_squares
*/
namespace perimeter_squares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("n: " + perimeter(5));
            Console.WriteLine("n: " + perimeter(7));
            Console.ReadKey();
        }
    /*
    The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8. It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80
    Could you give the sum of the perimeters of all the squares in a rectangle when there are n + 1 squares disposed in the same manner as in the drawing:
    */
    public static BigInteger perimeter(BigInteger n) 
    {
       n = (int)n + 1;
      var bigInts = new List<BigInteger>();
      for (int i = 0; i < n; i++)
      {
        if (i == 0 || i == 1)
        {
          bigInts.Add(new BigInteger(1));
        }
        else {
          var n1 = bigInts[i - 2];
          var n2 = bigInts[i - 1];
          bigInts.Add((n1+n2));
        }
       }
       if (bigInts.Count > 0) {
           var sum = bigInts.Aggregate(BigInteger.Add);
           return 4 * sum; 
       }
       return 0;
    }
  }
}
