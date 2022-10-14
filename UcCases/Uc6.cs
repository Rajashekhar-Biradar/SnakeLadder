using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class snakeUC6
    {
        public static int start = 0;
        public static int position = 0;
        public static int winPosition = 100;
        public static int diceRollNum = 0;
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
            int dice = snakeUC6.CheckDice();
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
                        Console.WriteLine("Player current position" + position);
                    }
                    else
                    {
                        position -= dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    if ((position + dice) > winPosition)
                    {
                        Console.WriteLine("Player position is above 100");
                        position -= dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    else if ((position + dice) == winPosition)
                    {
                        Console.WriteLine("Wins the game");
                        position = winPosition;
                        Console.WriteLine("Player current position" + position);
                    }
                    else
                    {
                        position += dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    break;
            }
        }
        public static void winningPosition()
        {
            //Repetation loop till reach winposition
            while (position < winPosition)
            {
                snakeUC6.CheckOption();
                diceRollNum++;
                Console.WriteLine("Number of times dice rolled :" + diceRollNum);
            }
        }
    }
}
