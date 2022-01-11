using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardManager = new BoardManager();
            var gameManager = new GameManager();
            Console.WriteLine("Welcome To Tic-Tac-Toe!");
            while(!boardManager.CheckGameOver())
            {
                Console.WriteLine(boardManager.PrintBoard());
                Console.WriteLine();
                boardManager.PlacePiece(gameManager.HandlePlayerTurn());
            }
        }

       
    }
}
