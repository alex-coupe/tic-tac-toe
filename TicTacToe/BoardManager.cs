using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class BoardManager : IBoardManager
    {
        private List<string> _board;
        public BoardManager()
        {
            _board = new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        }
        public string PrintBoard()
        {
            Console.WriteLine();
            return $"{_board[0]}{_board[1]}{_board[2]}\n{_board[3]}{_board[4]}{_board[5]}\n{_board[6]}{_board[7]}{_board[8]}";
        }

        public bool PlacePiece(string position)
        {
            var validPosition = int.TryParse(position, out var numberPosition);

            if (!validPosition || (numberPosition < 1 || numberPosition > 9))
                return false;

            if (_board[numberPosition-1] == "-")
            {
                _board[numberPosition-1] = "X";
                return true;
            }
            return false;
        }

        public bool CheckGameOver()
        {
            return CheckCrossesWin() || CheckNoughtsWin() || !_board.Any(x => x == "-");
        }

        public bool CheckNoughtsWin()
        {
            return (_board[0] == "O" && _board[1] == "O" && _board[2] == "O") ||
                (_board[0] == "O" && _board[3] == "O" && _board[5] == "O") ||
                (_board[0] == "O" && _board[4] == "O" && _board[8] == "O") ||
                (_board[2] == "O" && _board[4] == "O" && _board[6] == "O") ||
                (_board[2] == "O" && _board[5] == "O" && _board[8] == "O") ||
                (_board[6] == "O" && _board[7] == "O" && _board[8] == "O");
        }

        public bool CheckCrossesWin()
        {
            return (_board[0] == "X" && _board[1] == "X" && _board[2] == "X") ||
                (_board[0] == "X" && _board[3] == "X" && _board[5] == "X") ||
                (_board[0] == "X" && _board[4] == "X" && _board[8] == "X") ||
                (_board[2] == "X" && _board[4] == "X" && _board[6] == "X") ||
                (_board[2] == "X" && _board[5] == "X" && _board[8] == "X") ||
                (_board[6] == "X" && _board[7] == "X" && _board[8] == "X");

        }
    }
}
