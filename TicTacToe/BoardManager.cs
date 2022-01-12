using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class BoardManager : IBoardManager
    {
        private List<string> _board { get; }
        public BoardManager(List<string> board)
        {
            _board = board;
        }
        public string PrintBoard()
        {
            Console.WriteLine();
            return $"{_board[0]}{_board[1]}{_board[2]}\n{_board[3]}{_board[4]}{_board[5]}\n{_board[6]}{_board[7]}{_board[8]}";
        }

        public bool PlacePiece(string position, bool crossPiece)
        {
            var validPosition = int.TryParse(position, out var numberPosition);

            if (!validPosition || (numberPosition < 1 || numberPosition > 9))
                return false;

            if (_board[numberPosition - 1] == "-")
            {
                _board[numberPosition - 1] = crossPiece == true ?  "X" : "O";
                return true;
            }
            return false;
        }

        public bool CheckGameOver()
        {
            return CheckWin("O") || CheckWin("X") || !_board.Any(x => x == "-");
        }

        public bool CheckWin(string pieceType)
        {
            return (_board[0] == pieceType && _board[1] == pieceType && _board[2] == pieceType) ||
                (_board[0] == pieceType && _board[3] == pieceType && _board[6] == pieceType) ||
                (_board[0] == pieceType && _board[4] == pieceType && _board[8] == pieceType) ||
                (_board[2] == pieceType && _board[4] == pieceType && _board[6] == pieceType) ||
                (_board[2] == pieceType && _board[5] == pieceType && _board[8] == pieceType) ||
                (_board[3] == pieceType && _board[4] == pieceType && _board[5] == pieceType) ||
                (_board[1] == pieceType && _board[4] == pieceType && _board[7] == pieceType) ||
                (_board[6] == pieceType && _board[7] == pieceType && _board[8] == pieceType);

        }

        public List<string> CheckBoard()
        {
            return _board;
        }
    }
}
