using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Interfaces
{
    public interface IGameManager
    {
        string HandleCrossesTurn();
        string HandleNoughtsTurn(List<string> currentBoard);
    }
}
