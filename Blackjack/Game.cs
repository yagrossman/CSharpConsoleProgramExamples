using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   class Game
   {
      bool UserWon;
      bool ComputerWon;
      public int UserScore;
      public int ComputerScore;
      Deck Deck;

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
         //Console.WriteLine("Computer drew a {0} and now has {1} points.", computerCard.GetFace(), ComputerScore);
         if (ComputerScore == 21) ComputerWon = true;
         if (ComputerScore > 21) UserWon = true;
         return computerCard;
      }

      public Card UserMove()  // method to complete a users move
      {
         Card userCard = Deck.DrawCard();
         UserScore += userCard.GetValue();
         //Console.WriteLine("User drew a {0} and now has {1} points.", userCard.GetFace(), UserScore);
         if (UserScore == 21) UserWon = true;
         if (UserScore > 21) ComputerWon = true;
         return userCard;
      }

      public void GameWinCheck()
      {
         if (ComputerWon)
         {
            Console.WriteLine("Blackjack! The house always wins in the end! ;)");
            Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            //Environment.Exit(1);
         }
         if (UserWon)
         {
            Console.WriteLine("Blackjack! You Won! Great job sticking it to The Man! :)");
            Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            //Environment.Exit(1);
         }
      }
   }
}
