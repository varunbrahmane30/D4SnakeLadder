using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProblem
{
    
    class UC2RollDie
    {
        public const int startPos = 0;
        public const int player = 1;
        public const int winningPoints = 100;

        public static void rollDieByUser()
        {
            Random random = new Random();
            int roll = random.Next(1,7);

            Console.WriteLine("Result of die is :" + roll);
        }
    }
}
