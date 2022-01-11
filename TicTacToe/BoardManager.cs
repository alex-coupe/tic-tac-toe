using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class BoardManager : IBoardManager
    {
        private List<string> _board { get; }
        public BoardManager()
        {
            _board = new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        }
        public string PrintBoard()
        {
            return $"{_board[0]}{_board[1]}{_board[2]}\n{_board[3]}{_board[4]}{_board[5]}\n{_board[6]}{_board[7]}{_board[8]}";
        }
    }
}
