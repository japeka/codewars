using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

/*
Code wars
Level: 5kyu
Description:
    anagrams
*/
namespace anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",",Anagrams("a", new List<string> { "a", "b", "c", "d" })));
            Console.ReadKey();
        }
    /*
    What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:
        'abba' & 'baab' == true
        'abba' & 'bbaa' == true
        'abba' & 'abbba' == false
        'abba' & 'abca' == false    
    */
    public static List<string> Anagrams(string word, List<string> words)
    {
       List<string> list = new List<string>();
       char[] arr = word.ToCharArray();
       Array.Sort(arr);
       string sortedWord = string.Join("", arr);
       foreach (var w in words)
       {
         char[] arrTmp = w.ToCharArray();
         Array.Sort(arrTmp);
         string sortedWTmp = string.Join("",arrTmp);
         if (sortedWord == sortedWTmp)
         {
           list.Add(w);
         }
       }
       return list;
    }
  }
}
