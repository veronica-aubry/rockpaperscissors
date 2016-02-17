using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
namespace  rpsObjects
{
  public class rpsTest
  {
    [Fact]
    public void RPSWinner_ForDraw_returnP2_and_P1_DRAW()
    {
      Game newGame = new Game("paper", "paper");
      Assert.Equal("draw", newGame.RPSWinner());
    }

    [Fact]
    public void RPSWinner_ForRockPaper_returnP2Wins_paper()
    {
      Game newGame = new Game("rock", "paper");
      Assert.Equal("Player 2 Wins!!", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnP1Wins_paper()
    {
      Game newGame = new Game("PAPer", "rock");
      Assert.Equal("Player 1 Wins!!", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnP2Wins_scissors()
    {
      Game newGame = new Game("paper", "scissors");
      Assert.Equal("Player 2 Wins!!", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnP1Wins_scissors()
    {
      Game newGame = new Game("scissors", "paper");
      Assert.Equal("Player 1 Wins!!", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnP2Wins_Rock()
    {
      Game newGame = new Game("scissors", "rock");
      Assert.Equal("Player 2 Wins!!", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnP1Wins_Rock()
    {
      Game newGame = new Game("rock", "scissors");
      Assert.Equal("Player 1 Wins!!", newGame.RPSWinner());
    }
  }
}
