using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IBoardManager
    {
        string PrintBoard();
        bool PlacePiece(string position);
        bool CheckNoughtsWin();
        bool CheckCrossesWin();
        bool CheckGameOver();
    }
}
