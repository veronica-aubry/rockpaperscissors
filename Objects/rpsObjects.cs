
using System;
using System.Linq;
using System.Collections.Generic;


namespace rpsObjects {

  public class Game {
    private string _player1Input;
    private string _player2Input;
    private int _player1InputInt;
    private int _player2InputInt;

    public static Dictionary<string,int> _optionScores = new Dictionary<string,int>
    {
      {"rock", 4},
      {"paper", 2},
      {"scissors", 1}
    };

    public static Dictionary<int,string> _optionWins = new Dictionary<int,string>
    {
      {6, "paper"},
      {5, "rock"},
      {3, "scissors"}

    };

    public Game (string player1Input, string player2Input) {
      _player1Input = player1Input;
      _player2Input = player2Input;
    }

    public string RPSWinner(){

      if (_player1Input == _player2Input) {
        return "draw";
      }else {
        foreach (KeyValuePair<string,int> options in _optionScores) {
          if (options.Key == _player1Input) {
            int _player1InputInt = options.Value;
          }
          if (options.Key == _player2Input) {
            int _player2InputInt = options.Value;
          }
        }
        int gameTotal = _player1InputInt + _player2InputInt;
        foreach (KeyValuePair<string,int> options in _optionWins) {
          if (options.Key == gameTotal) {
            string winningMove = options.Value;
            System.Console.WriteLine(winningMove);
          }
        }
        if (_player1Input == winningMove) {
          return "Player 1 Wins!!";
        }else {
          return "Player 2 Wins!!";
        }
      }
    }
  }
}
