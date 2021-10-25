using System;
using YafetBattleShip;


namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {


                var startgame = new yafetBattleShipReview.Greeting();
                var gameboard = new Gameboard();

            startgame.UserGreeting();
           gameboard.Randomize();
            while (gameboard.GetHitCount() < 17)
            {
              gameboard.DisplayBoard(gameboard.GetGrid());
                gameboard.AskInput();
            }

            //    Console.WriteLine("Congrats you win!");
            //    Console.WriteLine("you missed: "+ p.getMissCount() + " times");
            //    Console.WriteLine("Please press enter to quite");
            //    System.Console.ReadLine();
        }

    }
}