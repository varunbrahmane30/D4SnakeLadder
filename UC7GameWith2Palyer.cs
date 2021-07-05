using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProblem
{
    class UC7GameWith2Palyer
    {
		public static int player1Pos = 0;       //player starting position
		public static int player2Pos = 0;
		public static int winningPoints = 100;      //points to win the match
		public static int diceCount = 0;        //declared variable for dice count
		public static int playerShuffle = 0;

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

		public static String whichPlayer()
		{

			playerShuffle++;
			if (playerShuffle % 2 == 0)
			{

				return "player1";
			}
			else
			{

				return "player2";
			}
		}

		public static void play()
		{

			while (player1Pos < 100 || player2Pos < 100)
			{

				String player = whichPlayer();
				int value = rollDice();         //call to rollDice method
				int option = checkOption();     //call to checkOption method
				diceCount++;                //increment dice count

				switch (option)
				{

					case 1:
						Console.WriteLine("There are no play!!!"); //no play if choose 1
						break;
					case 2:
						Console.WriteLine("You got a ladder");     //ladder if choose 2
						if (player == "player1")
						{

							player1Pos += value;                //add dice value to the player position

						}
						else if (player == "player2")
						{

							player2Pos += value;
						}

						if (player1Pos > winningPoints)
						{           //checking winning condition

							player1Pos -= value;
						}
						else if (player2Pos > winningPoints)
						{

							player2Pos -= value;
						}
						else
						{
						}
						Console.WriteLine("current position of player1 is:" + player1Pos);
						Console.WriteLine("current position of player2 is:" + player2Pos);
						break;
					case 3:
						Console.WriteLine("You got a snake");      //snake if choose 3
						if (player == "player1")
						{

							player1Pos -= value;            //subtact dice value from player position
						}
						else if (player == "player2")
						{

							player2Pos -= value;
						}
						else
						{
						}
						if (player1Pos < 0)
						{           //check condition if player gets lower that 0 restart

							player1Pos = 0;
						}
						else if (player2Pos < 0)
						{

							player2Pos = 0;
						}
						Console.WriteLine("current position of player1 is:" + player1Pos);
						Console.WriteLine("current position of player2 is:" + player2Pos);
						break;
					

				}

				if (player1Pos == 100)
				{               //checking who is winner here

                    Console.WriteLine( diceCount + " times dice rolled to win by player1");
					break;
				}
				else if (player2Pos == 100)
				{

					Console.WriteLine(diceCount + " times dice rolled to win by player2");
					break;
				}
			}
		}
	}
}
