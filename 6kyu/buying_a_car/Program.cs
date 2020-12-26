using System;
/*
Code wars
Level: 6kyu
Description:
    buying_a_car
*/
namespace buying_a_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buying a car");
            int[] p = nbMonths(2000, 8000, 1000, 1.5);
            Console.WriteLine(string.Join(",", p)); 

            Console.ReadKey();
        }

        /*  
            A man has a rather old car being worth $2000. He saw a secondhand car 
            being worth $8000. He wants to keep his old car until he can buy the secondhand one.

            He thinks he can save $1000 each month but the prices of his old car and of the new one 
            decrease of 1.5 percent per month. Furthermore this percent of loss increases of 0.5 percent 
            at the end of every two months. Our man finds it difficult to make all these calculations.
        */
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth) {

            int i = 0;
            double oldCar = startPriceOld;
            double newCar = startPriceNew;
            int savings = 0;
            if (oldCar >= newCar)
            {
                return new int[] { 0, ((int)oldCar - (int)newCar) };
            }
            else
            {
                double subtr = 0;
                while (true)
                {
                    savings += savingPerMonth;
                    if (i % 2 == 0)
                    {
                        percentLossByMonth += 0.5;
                        oldCar = oldCar * ((100 - (percentLossByMonth + 0.5)) / 100);
                        newCar = newCar * ((100 - (percentLossByMonth + 0.5)) / 100);
                    }
                    else
                    {
                        oldCar = oldCar * ((100 - percentLossByMonth) / 100);
                        newCar = newCar * ((100 - percentLossByMonth) / 100);
                    }

                        oldCar = oldCar * ((100 - percentLossByMonth) / 100);
                        newCar = newCar * ((100 - percentLossByMonth) / 100);

                    subtr = (savings + oldCar) - newCar;
                    if (subtr >= 0)
                    {
                        break;
                    }
                    i++;
                }
                return new int[] { i, (int)(System.Math.Round(subtr)) };
        }
    }
}
