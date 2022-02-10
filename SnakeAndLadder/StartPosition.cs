using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder; 

internal class StartPosition
{
    private int position;
    private bool winCheck;
    private int totalDieRoll;

    static Random random = new Random();

    public StartPosition() 
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }

    public void Reset()
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }


    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    public void RollDie()
    {
        int chkContinue = 0;
        int roll = random.Next(1, 7);
        Console.WriteLine("\nRolled: " + roll);
        if (winCheck is false)
            chkContinue = MovePlayer(roll);
        if (winCheck is false && chkContinue == 1)
            Option(roll);
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
        MovePlayer(-roll);
    }

    // Actions to take when option is ladder
    private void Ladder(int roll)
    {
        Console.WriteLine("Yay! A Ladder!!!");
        Console.WriteLine("Going up by " + roll);
        MovePlayer(roll);
    }


    //Repeat till the Player reaches the winning position 100.
    private int CheckBoundary(int displacement)
    {
        if (position < 0)
        {
            position = 0;
            return 0;
        }
        else if (position > 100)
        {
            position -= displacement;
            Console.WriteLine("Oops! You shot past position 100");
            Console.WriteLine("You are moved back to previous position");
            return 0;
        }
        else
            return 1;
    }

    // Move player acroos the board

    private int MovePlayer(int displacement)
    {
        position += displacement;
        if (position == 100)
        {
            winCheck = true;
            return 0;
        }
        return CheckBoundary(displacement);
    }

    // This will roll die untill player wins
    public void PlayTillEnd(StartPosition player2)
    {
        while (this.winCheck is false && player2.winCheck is false)
        {
            Console.WriteLine("\nPlayer 1 turn: ");
            this.RollDie();
            this.Describe();
            if (this.winCheck is true)
                break;
            Console.WriteLine("\nPlayer 2 turn: ");
            player2.RollDie();
            player2.Describe();
        }
        if (player2.winCheck is true)
            Console.WriteLine("\nCongratulations Player 2!! You Won!!");
        else
            Console.WriteLine("\nCongratulations Player 1!! You Won!!");
        Console.WriteLine("Player 1 Total die rolls: " + this.totalDieRoll);
        Console.WriteLine("Player 2 Total die rolls: " + player2.totalDieRoll);
    }




}
