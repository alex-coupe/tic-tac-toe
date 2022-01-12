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
            Console.WriteLine(boardManager.PrintBoard());
            Console.WriteLine();
            while (!boardManager.CheckGameOver())
            {
                Console.WriteLine();
                while(!boardManager.PlacePiece(gameManager.HandleCrossesTurn(), true))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Selection");
                }
                Console.WriteLine();
                Console.WriteLine(boardManager.PrintBoard());
                if (boardManager.CheckWin("X"))
                    break;
                Console.WriteLine();
                boardManager.PlacePiece(gameManager.HandleNoughtsTurn(boardManager.CheckBoard()),false);
                Console.WriteLine();
                Console.WriteLine(boardManager.PrintBoard());
            }

            if (boardManager.CheckWin("X"))
                Console.WriteLine("You Won!");
            else if (boardManager.CheckWin("O"))
                Console.WriteLine("You Lost!");
            else
                Console.WriteLine("Draw!");
            Console.ReadKey();
        }
    }
}
