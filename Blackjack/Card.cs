using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   class Card
   {
      string Suit;
      string Rank;

      public Card(string suit, string rank)  // Card Constructor
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

      public int GetValue()   // method to return value of a card
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

      public string GetFace() // method to return string of card value;
      {
         string face = String.Format(
            this.Rank + " of " + this.Suit); 
          //"\n+---------+\n"+
          //  "|{0}       |\n"+
          //  "|         | \n"+
          //  "|  {1} |    \n"+
          //  "|         | \n"+
          //  "|       {0}|\n"+
          //  "+---------+", this.Rank, this.Suit);
         
         return face;
      }
      public static string guiCard(Card card) // method to return a GUI card
      {
         if (card.Suit == "Clubs")
         {
            switch (card.Rank)
            {
               case "Ace": return "1.png";
               case "2": return "49.png";
               case "3": return "45.png";
               case "4": return "41.png";
               case "5": return "37.png";
               case "6": return "33.png";
               case "7": return "29.png";
               case "8": return "25.png";
               case "9": return "21.png";
               case "10": return "17.png";
               case "Jack": return "13.png";
               case "Queen": return "9.png";
               case "King": return "5.png";
               default: return "b1fv.png";
            }
         }
         else if (card.Suit == "Spades")
         {
            switch (card.Rank)
            {
               case "Ace": return "2.png";
               case "2": return "50.png";
               case "3": return "46.png";
               case "4": return "42.png";
               case "5": return "38.png";
               case "6": return "34.png";
               case "7": return "30.png";
               case "8": return "26.png";
               case "9": return "22.png";
               case "10": return "18.png";
               case "Jack": return "14.png";
               case "Queen": return "10.png";
               case "King": return "6.png";
               default: return "b1fv.png";
            }
         }
         else if (card.Suit == "Hearts")
         {
            switch (card.Rank)
            {
               case "Ace": return "3.png";
               case "2": return "51.png";
               case "3": return "47.png";
               case "4": return "43.png";
               case "5": return "39.png";
               case "6": return "35.png";
               case "7": return "31.png";
               case "8": return "27.png";
               case "9": return "23.png";
               case "10": return "19.png";
               case "Jack": return "15.png";
               case "Queen": return "11.png";
               case "King": return "7.png";
               default: return "b1fv.png";
            }
         }
         else
         {
            switch (card.Rank)
            {
               case "Ace": return "4.png";
               case "2": return "52.png";
               case "3": return "48.png";
               case "4": return "44.png";
               case "5": return "40.png";
               case "6": return "36.png";
               case "7": return "32.png";
               case "8": return "28.png";
               case "9": return "24.png";
               case "10": return "20.png";
               case "Jack": return "16.png";
               case "Queen": return "12.png";
               case "King": return "8.png";
               default: return "b1fv.png";
            }
         }
      }
   }
}
