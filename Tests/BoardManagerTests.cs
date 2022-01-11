using Moq;
using System;
using System.Collections.Generic;
using TicTacToe;
using Xunit;

namespace Tests
{
    public class BoardManagerTests
    {
        Mock<IBoardManager> _boardManagerMock;

        [Fact]
        public void printing_new_board_displays_correctly()
        {
            var boardManager = new BoardManager();
            var expectedResult = "---\n---\n---";

            Assert.Equal(expectedResult, boardManager.PrintBoard());
        }

        [Theory]
        [InlineData("1")]
        [InlineData("q")]
        [InlineData("2")]
        public void placing_piece_is_placed_on_free_spot_correctly(string position)
        {
            var boardManager = new BoardManager();
            boardManager.PlacePiece(position);
        }
    
    }
}
