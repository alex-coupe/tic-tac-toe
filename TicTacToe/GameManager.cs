using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Interfaces;

namespace TicTacToe
{
    public class GameManager : IGameManager
    {
        public string HandlePlayerTurn()
        {
            Console.WriteLine("Enter a number between 1 and 9 to choose where to place your X");
            Console.WriteLine("1 being top left and 9 being bottom right");
            return Console.ReadKey().KeyChar.ToString();
        }
    }
}
