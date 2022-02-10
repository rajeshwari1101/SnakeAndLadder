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
}
