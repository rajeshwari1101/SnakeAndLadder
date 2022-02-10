using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class StartPosition
    {
        int position;

        public StartPosition() 
        {
            position = 0;
        }

        public void Describe()
        {
            Console.WriteLine("Position: " + position);
        }
    }
}
