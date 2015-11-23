using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
   class Card
   {
      string Suit;
      string Rank;

      public Card(string suit, string rank)
      {
         for (int i = 0; i < 4; i++)
         {
            if (ValidSuits()[i] == suit)
            {
               Suit = suit;
               break;
            }
         }
         if(Suit==null) Console.WriteLine("Invalid Suit");
         for (int i = 0; i < 13; i++)
         {
            if (ValidRanks()[i] == rank)
            {
               Rank = rank;
               break;
            }
         }
         if (Rank == null) Console.WriteLine("Invalid Rank");
      }

      public static string[] ValidSuits()
      {
         string[] validSuitArray = new string[4] 
         { "Hearts", "Spades", "Diamonds", "Clubs" };
         return validSuitArray;
      }

      public static string[] ValidRanks()
      {
         string[] validRankArray = new string[13]
            {"Ace", "2", "3", "4", "5", "6", "7", "8", "9",
            "10", "Jack", "Queen", "King"};
         return validRankArray;
      }
   }
}
