using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IBoardManager
    {
        string PrintBoard();
        bool PlacePiece(string position, bool crossPiece);
        bool CheckWin(string piece);
        bool CheckGameOver();
        List<string> CheckBoard();
    }
}
