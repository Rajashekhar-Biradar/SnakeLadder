using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class snakeUC3
    {
        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 7);
            Console.WriteLine("Dice number: " + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int CheckOption = random.Next(0, 3);
            int position = 10;
            int dice = snakeUC3.CheckDice();
            switch (CheckOption)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    position -= dice;
                    Console.WriteLine("Player current position" + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    position += dice;
                    Console.WriteLine("Player current position" + position);
                    break;

            }
        }
    }
}
