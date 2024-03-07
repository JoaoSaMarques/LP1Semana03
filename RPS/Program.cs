using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Convert input strings to GameItem enums
            GameItem player1Choice = Enum.Parse<GameItem>(args[0]);
            GameItem player2Choice = Enum.Parse<GameItem>(args[1]);

            // Get the result using the updated method
            GameStatus result = RockPaperScissors(player1Choice, player2Choice);

            // Display the result
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        // Updated RockPaperScissors method using GameItem and GameStatus enums
        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw;
            }

            if ((player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
                (player1 == GameItem.Scissors && player2 == GameItem.Paper) ||
                (player1 == GameItem.Paper && player2 == GameItem.Rock))
            {
                return GameStatus.Player1Wins;
            }
            else
            {
                return GameStatus.Player2Wins;
            }
        }
    }
}
