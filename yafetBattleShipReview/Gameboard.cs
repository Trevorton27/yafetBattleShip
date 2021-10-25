using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YafetBattleShip
{
    class Gameboard
    {

        char[,] Grid = new char[10, 10];
        public int Hitcount = 0;
        public int Misscount = 0;
        int x = 0;
        int y = 0;



        public void DisplayBoard(char[,] Board)
        {
            int Row;
            int Column;

            WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Write(Board[Column, Row] + " ");
                }
                WriteLine();
            }

            WriteLine("\n");




        }

        public char[,] GetGrid()
        {
            return Grid;
        }
        public void SetGrid(int q, int w)
        {
            Grid[q, w] = ' ';
        }

        public void Randomize()
        {
            // test 

            Random r = new Random(2);
            //
            SetGrid(1, 2);
            SetGrid(2, 2);
            SetGrid(3, 2);
            ///
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);

            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
        }



        public int GetHitCount()
        {
            return Hitcount;
        }

        public int getMissCount()
        {
            return Misscount;
        }
        public void AskInput()
        {

            WriteLine("Enter vertical number ?");
            string Firstnum = ReadLine();
            int value;
            if (int.TryParse(Firstnum, out value))
            {
                x = value;
            }
            else
            {
                WriteLine("Wrong number");
            }

            WriteLine("Enter horizontal coordinate");
            string secondNum = ReadLine();
            if (int.TryParse(secondNum, out value))
            {
                y = value;

            }
            else
            {
                WriteLine("Wrong number");
            }

            try
            {
                int counts = 0;


                if (Grid[x, y].Equals(' '))
                {
                    Grid[x, y] = 'X';
                    counts++;
                    Clear();
                    BackgroundColor = ConsoleColor.Blue;
                    WriteLine(" Hit \r\n");
                    ResetColor();
                    Hitcount += 1;
                }
                else
                {
                    Grid[x, y] = 'O';
                    Clear();
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine(" Miss \r\n");
                    ResetColor();
                    Misscount += 1;

                }
            }
            catch
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine(" Error: Please enter number between 0 and 9 \r\n");
                ResetColor();
            }
        }

    }

}




