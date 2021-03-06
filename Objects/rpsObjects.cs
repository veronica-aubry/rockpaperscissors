
using System;
using System.Linq;
using System.Collections.Generic;


namespace rpsObjects {

  public class Game {
    private string _player1Input;
    private string _player2Input;
    private int _player1InputInt;
    private int _player2InputInt;
    private string winningMove;

    public static Dictionary<string,int> _optionScores = new Dictionary<string,int>
    {
      {"rock", 3},
      {"paper", 2},
      {"scissors", 1}
    };

    public static Dictionary<int,string> _optionWins = new Dictionary<int,string>
    {
      {5, "paper"},
      {4, "rock"},
      {3, "scissors"}
    };

    public Game (string player1Input, string player2Input) {
      _player1Input = player1Input.ToLower();
      _player2Input = player2Input.ToLower();
    }

    public string GetP1Name()
    {
      return _player1Input;
    }

    public string GetP2Name()
    {
      return _player2Input;
    }

    public string RandomPlayer()
    {
      Random r = new Random();
      int RPlayer = r.Next(1,4);
      _player2Input = _optionScores.FirstOrDefault(x => x.Value == RPlayer).Key;
      return _player2Input;
    }



    public string RPSWinner(){


      if (_player1Input == _player2Input) {
        return "draw";
      }else {
        foreach (KeyValuePair<string,int> options in _optionScores) {
          if (options.Key == _player1Input) {
            _player1InputInt = options.Value;
          }
          if (options.Key == _player2Input) {
             _player2InputInt = options.Value;
          }
        }
        int gameTotal = _player1InputInt + _player2InputInt;
        foreach (KeyValuePair<int,string> options in _optionWins) {
          if (options.Key == gameTotal) {
            winningMove = options.Value;
          }
        }
        if (_player1Input == winningMove) {
          return "Player 1 Wins!!";
        }else if (_player2Input == winningMove){
          return "Player 2 Wins!!";
        }
        return "ya done fucked up";
      }
    }
  }
}
