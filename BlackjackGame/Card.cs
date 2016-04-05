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
         for (int i = 0; i < 4; i++)   // check and assign suit to card
         {
            if (ValidSuits()[i] == suit)
            {
               Suit = suit;
               break;
            }
         }
         if (Suit == null) Console.WriteLine("Invalid Suit");
         for (int i = 0; i < 13; i++)  // check and assign rank to card
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

      public int GetValue()
      {
         switch (this.Rank)
         {
            case "Ace": return 1;
            case "2": return 2;
            case "3": return 3;
            case "4": return 4;
            case "5": return 5;
            case "6": return 6;
            case "7": return 7;
            case "8": return 8;
            case "9": return 9;
            default: return 10;
         }
      }

      public string GetFace()
      {
         string face = String.Format(
            this.Rank + " of " + this.Suit + 
          "\n+---------+\n"+
            "|{0}       |\n"+
            "|         | \n"+
            "|  {1} |    \n"+
            "|         | \n"+
            "|       {0}|\n"+
            "+---------+", this.Rank, this.Suit);
         
         return face;
      }

   }

}
