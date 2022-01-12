using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Interfaces;

namespace TicTacToe
{
    public class GameManager : IGameManager
    {
        private Random random = new Random();
        public string HandleCrossesTurn()
        {
            Console.WriteLine("Enter a number between 1 and 9 to choose an empty space to place your X");
            Console.WriteLine("1 being top left and 9 being bottom right");
            return Console.ReadKey().KeyChar.ToString();
        }

        public string HandleNoughtsTurn(List<string> currentBoard)
        {
            int index = random.Next(1, 9);
            while(currentBoard[index-1] != "-")
                index = random.Next(1, 9);

            Console.WriteLine($"Noughts picks {index.ToString()}");
            return index.ToString();
        }
    }
}
