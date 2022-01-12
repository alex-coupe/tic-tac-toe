using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe;
using Xunit;

namespace Tests
{
    public class GameManagerTests
    {
        [Fact]
        public void handle_noughts_turn_will_return_index_for_empty_space()
        {
            var gameManager = new GameManager();
            var boardManager = new BoardManager(new List<string>(9) { "X", "X", "X", "X", "X", "X", "X", "X", "-" });

            var result = gameManager.HandleNoughtsTurn(boardManager.CheckBoard());
            Assert.Equal("9", result);
        }

        [Fact]
        public void handle_noughts_turn_will_return_empty_for_full_board()
        {
            var gameManager = new GameManager();
            var boardManager = new BoardManager(new List<string>(9) { "X", "X", "X", "X", "X", "X", "X", "X", "X" });

            var result = gameManager.HandleNoughtsTurn(boardManager.CheckBoard());
            Assert.Equal("", result);
        }
    }
}
