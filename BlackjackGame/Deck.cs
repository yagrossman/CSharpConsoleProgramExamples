﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
   class Deck
   {
      public Card[] Cards { get; set; }
      public Random Randomizer { get; set; }
      int cardsLeftInDeck = 52;

      public Deck()
      {
         Cards = new Card[52];
         int cardsPos = 0;
         foreach (string rank in Card.ValidRanks())
         {
            foreach (string suit in Card.ValidSuits())
            {
               Cards[cardsPos++] = new Card(suit, rank);
            }
         }
         Randomizer = new Random();
      }

      public Card DrawCard()
      {
         if(cardsLeftInDeck == 0) { // ensures there are still cards to draw from.
            Console.WriteLine("Deck is empty. Press any key to Exit");
            Console.ReadKey();
            Environment.Exit(1);
         }
         int rnd;
         do //get position of card that hasnt been picked from deck yet
         {
          rnd = Randomizer.Next(0, 52);
         } while (Cards[rnd] == null);
         Card drawnCard = Cards[rnd];
         Cards[rnd] = null; // "remove" card from deck
         cardsLeftInDeck -= 1;
         return drawnCard;
      }
   }
}
