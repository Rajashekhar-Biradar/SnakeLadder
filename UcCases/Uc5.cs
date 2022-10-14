using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class snakeUC5
    {
        public static int start = 0;
        public static int position = 0;
        public static int winposition = 100;

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
            int dice = snakeUC5.CheckDice();
            switch (CheckOption)
            {
                case 0:
                    Console.WriteLine("No Play");
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
                    if ((position + dice) > winposition)
                    {
                        Console.WriteLine("Player current position is above 100");
                        position -= dice;
                        Console.WriteLine("Player current position: " + position);
                    }
                    else if ((position + dice) == winposition)
                    {
                        Console.WriteLine("Win the game");
                        position = winposition;
                        Console.WriteLine("Player current position: " + position);
                    }
                    else
                    {
                        position += dice;
                        Console.WriteLine("Player current position: " + position);
                    }
                    break;
            }
        }
        public static void winningPosition()
        {
            while (position < winposition)
            {
                snakeUC5.CheckOption();
            }
        }
    }
}