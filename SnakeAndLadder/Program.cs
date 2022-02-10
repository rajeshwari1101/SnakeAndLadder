using System;

namespace SnakeAndLadder
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartPosition player1 = new StartPosition();
            StartPosition player2 = new StartPosition();
            Console.WriteLine("Player 1: ");
            player1.Describe();
            Console.WriteLine("Player 2: ");
            player2.Describe();
            player1.PlayTillEnd(player2);
            Console.ReadKey();
        }
    }
}

