//using System;
//using System.Collections.Generic;

//namespace BridgeLabzTraining.scenariobased
//{

//    class SnakeAndLadder
//    {
//        static void Main()
//        {
//            SnakeAndLadder obj = new SnakeAndLadder();
//            int players = obj.Getplayers();

//            string[] names = new string[players];
//            int[] positions = new int[players];

//            for (int i = 0; i < players; i++)
//            {
//                Console.Write("Give name for Player " + (i + 1) + ": ");
//                names[i] = Console.ReadLine();
//                positions[i] = 0;
//            }

//            int[] snakeLadderBoard = obj.SnakeLadderBoardDesign();
//            Random rnd = new Random();
//            bool gameWon = false;
//            int turn = 0;

//            while (!gameWon)
//            {
//                int currentPlayer = turn % players;

//                Console.WriteLine("\n " + names[currentPlayer] + "'s turn. Press Enter to roll dice...");
//                Console.ReadLine();
//                // Get score from dice roll
//                int diceNumber = rnd.Next(1, 7);
//                int oldPosition = positions[currentPlayer];
//                Console.WriteLine("Dice Rolled: " + diceNumber);

//                if (oldPosition + diceNumber <= 100)
//                {
//                    positions[currentPlayer] += diceNumber;

//                    if (snakeLadderBoard[positions[currentPlayer]] != 0)
//                    {
//                        int finalPosition = snakeLadderBoard[positions[currentPlayer]];
//                        if (finalPosition > positions[currentPlayer])
//                        {
//                            Console.WriteLine("Ladder Climbed at " + positions[currentPlayer] + " !!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Snake Slide down at " + positions[currentPlayer] + " !!");
//                        }
//                        positions[currentPlayer] = finalPosition;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Score exceeds 100. Turn skipped.");
//                }
//                Console.WriteLine(names[currentPlayer] + ": " + oldPosition + " -> " + positions[currentPlayer]);
//                if (positions[currentPlayer] == 100)
//                {
//                    Console.WriteLine("\n " + names[currentPlayer] + " WINS THE GAME!");
//                    gameWon = true;
//                }
//                turn++;
//            }
//        }
//        int Getplayers()
//        {
//            Console.Write("Give the number of names (2–4): ");
//            int count = int.Parse(Console.ReadLine());
//            return count;
//        }
//        int[] SnakeLadderBoardDesign()
//        {
//            int[] snakeLadderBoard = new int[101];

//            // Ladder positions on board
//            snakeLadderBoard[4] = 14;
//            snakeLadderBoard[9] = 31;
//            snakeLadderBoard[20] = 38;
//            snakeLadderBoard[28] = 84;
//            snakeLadderBoard[40] = 59;
//            snakeLadderBoard[63] = 81;

//            // Snake positions on board
//            snakeLadderBoard[17] = 7;
//            snakeLadderBoard[54] = 34;
//            snakeLadderBoard[62] = 19;
//            snakeLadderBoard[64] = 60;
//            snakeLadderBoard[87] = 36;
//            snakeLadderBoard[93] = 73;
//            snakeLadderBoard[95] = 75;
//            snakeLadderBoard[99] = 78;

//            return snakeLadderBoard;
//        }
//    }

//}