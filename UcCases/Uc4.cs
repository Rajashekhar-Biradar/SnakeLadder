using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class snakeUC4
    {
        public static int position = 0;
        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 7);
            Console.WriteLine("Dice Number :" + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int CheckOption = random.Next(0, 3);
            int dice = snakeUC4.CheckDice();
            switch (CheckOption)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    position -= dice;
                    Console.WriteLine("Player current position: " + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    position += dice;
                    Console.WriteLine("Player current position: " + position);
                    break;
            }
        }

        public static void winPosition()
        {
            int winPosition = 100;
            while (position <= winPosition)
            {
                snakeUC4.CheckOption();
                if (position == winPosition)
                {
                    Console.WriteLine("Player current position :" + position);
                }
                else if (position < 0)
                {
                    Console.WriteLine("Restart the game");
                    Console.WriteLine(" Player current position :" + position);
                }
                else
                {
                    Console.WriteLine("Player current position :" + position);
                }
            }
        }

    }
}
