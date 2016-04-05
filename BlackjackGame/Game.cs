using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
   class Game
   {
      bool UserWon;
      bool ComputerWon;
      int UserScore;
      int ComputerScore;
      Deck Deck;

      public Game()  // Game Constructor
      {
         UserWon = false;
         ComputerWon = false;
         UserScore = 0;
         ComputerScore = 0;
         Deck = new Deck();
      }

      public void ComputerMove() // method to complete a computer move
      {


      }

      public void UserMove()  // method to complete a users move
      {

      }

   }
}
