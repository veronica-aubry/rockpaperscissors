using Nancy;
using System;
using System.Linq;
using System.Collections.Generic;
using rpsObjects;

  namespace Project  {
      public class HomeModule : NancyModule {
        public HomeModule() {

        Get["/"] = _ => {
          return View["index.cshtml" ];
        };

        Get["/form"] = _ => {
          Game newGame = new Game("","");
          return View["form.cshtml", newGame];
        };

        Post["/form"] = _ => {
        Game newGame = new Game(Request.Form["player1-input"], Request.Form["player2-input"]);
          return View["form.cshtml", newGame];
        };

        Get["/form-computer"] = _ => {
          Game newGame = new Game("","");
          return View["form-computer.cshtml", newGame];
        };

        Post["/form-computer"] = _ => {
        Game newGame = new Game(Request.Form["player1-input"], "null");
        newGame.RandomPlayer();
        return View["form-computer.cshtml", newGame];
        };
      }
   }
}
