using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class snakeUC7
    {
        public static int start = 0;
        public static int position = 0;
        public static int winPosition = 100;

        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 7);
            Console.WriteLine("Dice number :" + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int CheckOption = random.Next(0, 3);
            int dice = snakeUC7.CheckDice();
            switch (CheckOption)
            {
                case 0:
                    Console.WriteLine("No play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    if ((position - dice) < start)
                    {
                        Console.WriteLine("Restart the game");
                        position = start;
                        Console.WriteLine("Player current position :" + position);
                    }
                    else
                    {
                        position -= dice;
                        Console.WriteLine("Player current position :" + position);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    if ((position - dice) > winPosition)
                    {
                        Console.WriteLine("Player position above 100");
                        position -= dice;
                        Console.WriteLine("Player current position :" + position);
                    }
                    else if ((position + dice) == winPosition)
                    {
                        Console.WriteLine("Wins the game");
                        position = winPosition;
                        Console.WriteLine("Player current position :" + position);
                    }
                    else
                    {
                        position += dice;
                        Console.WriteLine("Player current position :" + position);
                    }
                    break;
            }
        }
        public static void WinningPosition()
        {
            while (position < winPosition)
            {
                snakeUC7.CheckOption();
            }
        }

        public static void TwoPlayer()
        {
            while (true)
            {
                Random random = new Random();
                int checkTurn = random.Next(1, 3);
                if (checkTurn == 1)
                {
                    snakeUC7.WinningPosition();
                    if (position == winPosition)
                    {
                        Console.WriteLine("Player 1 Won");
                        break;
                    }
                }
                if (checkTurn == 2)
                {
                    snakeUC7.WinningPosition();
                    if (position == winPosition)
                    {
                        Console.WriteLine("Player 2 Won");
                        break;
                    }
                }
            }
        }

    }
}