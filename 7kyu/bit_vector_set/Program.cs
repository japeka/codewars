using System;
/*
Code wars
Level: 7kyu
Description:
    bit_vector_set
*/
namespace bit_vector_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bit_vector_set");
            SortByBit(new[] { 0, 1 });
            SortByBit(new[] { 1, 2, 0, 4 });
            Console.ReadKey();
        }

        /*  
            Write a function sortByBit which accepts an integer array as argument and
            returns a 32-bit integer such that the integer, in its binary representation has 1
            at only those indexes(counted from right) which are in the array.
        */
        public static int SortByBit(int[] array)
        {
            if (array.Length == 0) return 0;
            var bit32Ar = new int[32];
            foreach (var item in array)
            {
                if (item < bit32Ar.Length) {
                    bit32Ar[item] = 1;
                }
            }
            var bit32Chr = string.Join("", bit32Ar).ToCharArray();
            Array.Reverse(bit32Chr);
            return Convert.ToInt32(new string(bit32Chr), 2);
        }
    }
}


/* JS version of the function
function sortByBit(array) {
  if(array.length==0)  
    return 0;
  let bit32Arr = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];	
  array.forEach((item) => {
	if(item < bit32Arr.length){
		bit32Arr[item]=1;
	}
  });
  bit32Arr = bit32Arr.reverse();
  let sum = 0;
  for(let i = bit32Arr.length - 1, j=0; i >=0; i--,j++){
    sum += (bit32Arr[i]*Math.pow(2,j));
  }
  return sum;
}*/