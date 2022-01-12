using Moq;
using System;
using System.Collections.Generic;
using TicTacToe;
using Xunit;

namespace Tests
{
    public class BoardManagerTests
    {
        List<List<string>> _testData = new List<List<string>>
        {
            new List<string>
            {
                "X", "X", "X", "-", "-", "-", "-", "-", "-"
            },
            new List<string>
            {
                "-", "-", "-", "X", "X", "X", "-", "-", "-"
            },
            new List<string>
            {
                "-", "-", "-", "-", "-", "-", "X", "X", "X"
            },
            new List<string>
            {
                "X", "-", "-", "X", "-", "-", "X", "-", "-"
            },
            new List<string>
            {
                "-", "X", "-", "-", "X", "-", "-", "X", "-"
            },
            new List<string>
            {
                "-", "-", "X", "-", "-", "X", "-", "-", "X"
            },
             new List<string>
            {
                "X", "-", "-", "-", "X", "-", "-", "-", "X"
            },
               new List<string>
            {
                "-", "-", "X", "-", "X", "-", "X", "-", "-"
            },

               new List<string>
            {
                "O", "O", "O", "-", "-", "-", "-", "-", "-"
            },
            new List<string>
            {
                "-", "-", "-", "O", "O", "O", "-", "-", "-"
            },
            new List<string>
            {
                "-", "-", "-", "-", "-", "-", "O", "O", "O"
            },
            new List<string>
            {
                "O", "-", "-", "O", "-", "-", "O", "-", "-"
            },
            new List<string>
            {
                "-", "O", "-", "-", "O", "-", "-", "O", "-"
            },
            new List<string>
            {
                "-", "-", "O", "-", "-", "O", "-", "-", "O"
            },
             new List<string>
            {
                "O", "-", "-", "-", "O", "-", "-", "-", "O"
            },
               new List<string>
            {
                "-", "-", "O", "-", "O", "-", "O", "-", "-"
            }
        };

        [Fact]
        public void printing_new_board_displays_correctly()
        {
            var boardManager = new BoardManager(new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" });
            var expectedResult = "---\n---\n---";

            Assert.Equal(expectedResult, boardManager.PrintBoard());
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("1", false)]
        public void place_piece_assigns_the_correct_token(string position, bool crossPiece)
        {
            var boardManager = new BoardManager(new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" });

            boardManager.PlacePiece(position, crossPiece);

            if (crossPiece)
                Assert.Equal("X", boardManager.CheckBoard()[0]);
            else
                Assert.Equal("O", boardManager.CheckBoard()[0]);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("4")]
        [InlineData("5")]
        [InlineData("6")]
        [InlineData("7")]
        [InlineData("8")]
        [InlineData("9")]
        public void place_piece_functions_correctly_for_position_between_one_and_nine(string position)
        {
            var boardManager = new BoardManager(new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" });

            Assert.True(boardManager.PlacePiece(position, true));
        }

        [Theory]
        [InlineData("q")]
        [InlineData("10")]
        [InlineData("0")]
        [InlineData("_")]
        [InlineData("!")]
        public void place_piece_does_not_accept_invalid_characters(string position)
        {
            var boardManager = new BoardManager(new List<string>(9) { "-", "-", "-", "-", "-", "-", "-", "-", "-" });

            Assert.False(boardManager.PlacePiece(position, true));
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        public void place_piece_does_not_accept_for_taken_positions(string position)
        {
            var boardManager = new BoardManager(new List<string>(9) { "X", "O", "-", "-", "-", "-", "-", "-", "-" });

            Assert.False(boardManager.PlacePiece(position, true));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void check_win_returns_true_for_all_possible_cross_outcomes(int dataIndex)
        {
            var boardManager = new BoardManager(_testData[dataIndex]);
            Assert.True(boardManager.CheckWin("X"));
            Assert.True(boardManager.CheckGameOver());
        }

        [Theory]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        public void check_win_returns_true_for_all_possible_noughts_outcomes(int dataIndex)
        {
            var boardManager = new BoardManager(_testData[dataIndex]);
            Assert.True(boardManager.CheckWin("O"));
            Assert.True(boardManager.CheckGameOver());
        }


        [Fact]
        public void check_win_returns_false_for_non_winning_board()
        {
            var data = new List<string> { "X", "O", "X", "X", "O", "X", "O", "X", "O" };
            var boardManager = new BoardManager(data);
            Assert.False(boardManager.CheckWin("X"));
            Assert.False(boardManager.CheckWin("O"));
            Assert.True(boardManager.CheckGameOver());
        }
    }
}
