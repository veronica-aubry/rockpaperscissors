using Nancy;
using System;
using System.Linq;
using System.Collections.Generic;
using rpsObjects;

  namespace Project  {
      public class HomeModule : NancyModule {
        public HomeModule() {

        Get["/"] = _ => {
          Game newGame = new Game("","");
          return View["form.cshtml", newGame];
        };

        Post["/"] = _ => {
        Game newGame = new Game(Request.Form["player1-input"], Request.Form["player2-input"]);
          return View["form.cshtml", newGame];
        };
      }
   }
}
