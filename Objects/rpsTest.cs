using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
namespace  rpsObjects
{
  public class rpsTest
  {
    [Fact]
    public void RPSWinner_ForDraw_returnFalse()
    {
      Game newGame = new Game("paper", "paper");
      Assert.Equal("draw", newGame.RPSWinner());
    }
    [Fact]
    public void RPSWinner_For_returnFalse()
    {
      Game newGame = new Game("rock", "paper");
      Assert.Equal("Player 2 Wins!!", newGame.RPSWinner());
    }
  }
}
