using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProblem
{
	class UC6CalDiceCount
	{
		public static int playerPos = 0;
		public static int winningPoints = 100;
		public static int diceCount = 0;
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
			while (playerPos < 100)
			{
				int value = rollDice();
				int option = checkOption();

				switch (option)
				{

					case 1:
						Console.WriteLine("There are no play!!!"); //no play if choose 1
						break;
					case 2:
						Console.WriteLine("You got a ladder");     //ladder if choose 2
						playerPos += value;             //add dice value to the player position

						if (playerPos > winningPoints)
						{           //checking winning condition

							playerPos -= value;
						}
						Console.WriteLine("current position is:" + playerPos);
						break;
					case 3:
						Console.WriteLine("You got a snake");      //snake if choose 3
						playerPos -= value;             //subtact dice value from player position
						if (playerPos < 0)
						{           //check condition if player gets lower that 0 restart

							playerPos = 0;
						}
						Console.WriteLine("current position is:" + playerPos);
						break;
				}
				if (playerPos < 100)
				{
					continue;
				}
				else
				{

                    Console.WriteLine(diceCount + " times dice rolled to win by player1");
					break;
				}
			}
		}
	}
}

