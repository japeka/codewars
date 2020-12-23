using System;
/*
Code wars
Level: 8kyu
Description:
    The company you work for has just been awarded a contract to build a payment gateway. 
    In order to help move things along, you have volunteered to create a function that will 
    take a float and return the amount formatting in dollars and cents.
*/
namespace dollars_cents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dollars and cents");
            System.Console.WriteLine(FormatMoney(5172.96));
            Console.ReadKey();
        }
        public static string FormatMoney(double amount)
        {
            return amount.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")).Replace(",","");
        }
    }
}
