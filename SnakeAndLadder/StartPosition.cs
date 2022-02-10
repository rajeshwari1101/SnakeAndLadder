using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder; 

internal class StartPosition
{
    private int position;

    static Random random = new Random();

    public StartPosition() 
    {
        position = 0;
    }

    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    public void RollDie()
    {
        int roll = random.Next(1, 7);
        Console.WriteLine("Rolled: " + roll);
        position += roll;
        Describe();
    }


    //The Player then checks for a option. They are no play, ladder or snake.

    public void Option(int roll)
    {
        int option = random.Next(0, 3);
        switch (option)
        {
            case 0:
                Console.WriteLine("No Play");
                break;
            case 1:
                Ladder(roll);
                break;
            case 2:
                Snake(roll);
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }

    // Actions to take when option is snake
    private void Snake(int roll)
    {
        Console.WriteLine("Oops! Snake Trap!!!");
        Console.WriteLine("Going down by " + roll);
        position -= roll;
    }

    // Actions to take when option is ladder
    private void Ladder(int roll)
    {
        Console.WriteLine("Yay! A Ladder!!!");
        Console.WriteLine("Going up by " + roll);
        position += roll;
    }


    //Repeat till the Player reaches the winning position 100.
    private void CheckBoundary()
    {
        if (position < 0)
            position = 0;
        else if (position >= 100)
            position = 100;
    }

    public void PlayTillEnd()
    {
        while (position < 100)
            RollDie();
        Console.WriteLine("\nCongratulations!! You Won!!");
    }
}
