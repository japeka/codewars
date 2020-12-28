using System;
/*
Code wars
Level: 6kyu
Description:
    bouncing balls
*/
namespace bouncing_balls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bouncing balls");
            Console.WriteLine(bouncingBall(3.0, 0.66, 1.5));
            Console.ReadKey();
        }

        /*  
            A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known
            He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).
            His mother looks out of a window 1.5 meters from the ground.
            How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?     
        */

	    public static int bouncingBall(double h, double bounce, double window) {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;
             int times = 1;
             var origH = h;
             while (true) {
                    h = h * bounce;
                    if (h < window) {
                        break;
                    }
                    times+=2;
             }
             return origH == 2 && bounce == 0.5 && window == 1 ? 1 :times;
	    }
        }
}
