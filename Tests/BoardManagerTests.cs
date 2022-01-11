using System;
using TicTacToe;
using Xunit;

namespace Tests
{
    public class BoardManagerTests
    {
        [Fact]
        public void printing_new_board_displays_correctly()
        {
            var boardManager = new BoardManager();
            var expectedResult = "---\n---\n---";

            Assert.Equal(expectedResult, boardManager.PrintBoard());
        }
    }
}
