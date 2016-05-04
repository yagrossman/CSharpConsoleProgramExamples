using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   class Game
   {
      public bool UserWon;
      public bool ComputerWon;
      public int UserScore;
      public int ComputerScore;
      public Deck Deck;

      public Game()  // Game Constructor
      {
         UserWon = false;
         ComputerWon = false;
         UserScore = 0;
         ComputerScore = 0;
         Deck = new Deck();
      }

      public Card ComputerMove() // method to complete a computer move
      {
         Card computerCard = Deck.DrawCard();
         ComputerScore += computerCard.GetValue();
         if (ComputerScore == 21) ComputerWon = true;
         if (ComputerScore > 21) UserWon = true;
         return computerCard;
      }

      public Card UserMove()  // method to complete a users move
      {
         Card userCard = Deck.DrawCard();
         UserScore += userCard.GetValue();
         if (UserScore == 21) UserWon = true;
         if (UserScore > 21) ComputerWon = true;
         return userCard;
      }
   }
}
