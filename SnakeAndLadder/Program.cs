using System;

namespace SnakeAndLadder
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartPosition player1 = new StartPosition();
            player1.Describe();
            player1.PlayTillEnd();
            Console.ReadKey();
        }
    }
}

