using System;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 4kyu
Description:
    snail
*/
namespace snail
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
               new int []{1, 2, 3, 4, 5},
               new int []{11, 22, 33, 44, 55},
               new int []{222, 222, 333, 444, 555},
               new int []{1111, 2222, 3333, 4444, 5555},
               new int []{11111, 22222, 33333, 44444, 55555},
            };
            var arr = Snail(array);
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();
        }
   /*
    Given an n x n array, return the array elements arranged from outermost elements
    to the middle element, traveling clockwise.
   */
   public static int[] Snail(int[][] array)
   {
        var x = array.GetLength(0);
        var y = x > 0 ? array[0].Length : 0;
        var valid = array.All(s => s.Length == x);
        bool right = true; bool down = false; bool left = false; bool up = false;
        List<int> list = new List<int>();
        if (valid)
        {
           int i = 0; int j = 0;
           var hori = x;
           var vert = y;
           var zeroLimit = 0;
           var centralPointI = (x % 2 == 0) ? ((int)(x / 2) - 1)  : (int)(x / 2);
           var centralPointJ = (int)(x / 2);
           while (true) {
                    if (right) {
                        while (j < vert) {
                            if (j == (vert - 1)) {
                                if (j == centralPointI && i == centralPointI) {
                                    list.Add(array[i][j]);
                                    goto label;
                                }
                                list.Add(array[i][j]);
                                i++;
                                right = false;
                                down = true;
                                break;
                            }
                            list.Add(array[i][j]);
                            j++;
                        }
                    }
                    if (down)
                    {
                        while (i < hori)
                        {
                            if (i == (hori - 1)) {
                                list.Add(array[i][j]);
                                j--;
                                down = false;
                                left = true;
                                break;
                            }   
                            list.Add(array[i][j]);
                            i++;
                        }
                    }
                    if (left)
                    {
                        while (j >= zeroLimit)
                        {
                            if (j == zeroLimit) {
                                if (j == centralPointI && i == centralPointJ)
                                {
                                    list.Add(array[i][j]);
                                    goto label;
                                }
                                list.Add(array[i][j]);
                                i--;
                                up = true;
                                left = false;
                                break;
                            }
                            list.Add(array[i][j]);
                            j--;   
                        }
                    }
                    if (up)
                    {
                        zeroLimit++;
                        while (i >= zeroLimit) {
                            if (i == zeroLimit) {
                                list.Add(array[i][j]);
                                j++;
                                right = true;
                                up = false;
                                vert--;
                                hori--;
                                break;
                            }
                            list.Add(array[i][j]);
                            i--;
                        }
                    }
                }
            }
            label:
            return list.ToArray();
        }
  }
}
