using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace yafetBattleShipReview
{
    class Greeting
    {
        public void UserGreeting()
        {
            WriteLine();
            WriteLine();
            WriteLine("Hello, please enter your name. ");
            string name = Console.ReadLine();
            Write("\nHi " + name + "," + " Enter horizontal and vertical numbers to play the game. \n\n ");
        }
    }
}
