using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProblem
{
	class UC3CheckOption
	{
		public static int playerPos = 0;
		public static int winningPoints = 100;

		public static int rollDice()
		{

			Random random = new Random();
			int roll = random.Next(1, 7);

			return roll;
		}

		public static int checkOption()
		{
			Random random = new Random();
			int option = random.Next(0, 4);

			return option;
		}

		public static void playerPLayed()
		{
			int value = rollDice();
			int option = checkOption();

			switch (option)
			{

				case 1:
					Console.WriteLine("There are no play!!!");
					break;
				case 2:
					Console.WriteLine("You got a ladder");
					playerPos += value;
					Console.WriteLine("current position is:" + playerPos);
					break;
				case 3:
					Console.WriteLine("You got a snake");
					playerPos -= value;
					if (playerPos < 0)
					{

						playerPos = 0;
					}
					Console.WriteLine("current position is:" + playerPos);
					break;
			}
		}
	}
}

