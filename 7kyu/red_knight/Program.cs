using System;
/*
Code wars
Level: 7kyu
Description:
    Red Knight is chasing two pawns. Which pawn will be caught, and where?
*/
namespace dollars_cents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Red Knight");
            Console.WriteLine(RedKnight(1, 5)); 
            Console.WriteLine(RedKnight(0, 4)); 
            Console.ReadKey();
        }

        /*  Red Knight will always start at horizontal position 0.
            The black pawn will always be at the bottom (vertical position 1).
            The white pawn will always be at the top (vertical position 0).
            The pawns move first, and they move simultaneously.
            Red Knight moves 2 squares forward and 1 up or down.
            Pawns always move 1 square forward.
            Both pawns will start at the same horizontal position.
        */
        public static (string color, long position) RedKnight(int knight, long pawn)
        {
            if ((knight == 0 || knight == 1) && (pawn >= 2 && pawn <= 1000000)) {
                var _pawns = pawn;
                var knight_y = knight;
                var knight_x = 0;
                while (knight_x <= 1000000) {
                    _pawns++;
                    knight_x += 2;
                    knight_y = knight_y == 0 ? 1 : 0;
                    if (knight_x == _pawns) {
                       return (knight_y == 0 ? "White" : "Black", knight_x);                     
                    }
                }
            }
            return (knight == 0 ? "White" : "Black", (pawn * 2L));
        }


    }
}
