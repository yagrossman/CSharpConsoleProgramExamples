using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackProject
{
   class Card
   {

      private string _Suit;
      private string _Rank;
      //card consturctor
      public Card(String suit, String rank)
      {
         this.Suit = suit;
         this.Rank = rank;

      }
      public String Suit
      {
         get
         {
            return _Suit;
         }
         set
         {
            //checks if the suit value is valid by checking if it exists in the "arrray of valid suits"
            string suitToCheck = value;
            string[] arrayOfValidSuits = ValidSuits();
            foreach (string x in arrayOfValidSuits)
            {
               if (x.Contains(suitToCheck))
               {
                  _Suit = suitToCheck;
                  break;
               }

            }

         }
      }
      public String Rank
      {
         get
         {
            return _Rank;
         }
         set
         {
            //checks if the rank value is valid by checking if it exists in the "arrray of valid ranks"
            string rankToCheck = value;
            string[] arrayOfValidRanks = ValidRanks();
            foreach (string x in arrayOfValidRanks)
            {
               if (x.Contains(rankToCheck))
               {
                  _Rank = rankToCheck;
                  break;
               }

            }

         }
      }
      // returns an array containing valid suits
      public static string[] ValidSuits()
      {
         string[] strings = new string[] { "Hearts", "Spades", "Diamonds", "Clubs" };
         return strings;
      }
      // returns an aray of the valid ranks
      public static string[] ValidRanks()
      {
         String[] strings = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
         return strings;
      }
      //returns the rank as a valid integer
      public int GetValue()
      {
         if (_Rank.Equals("Ace"))
         {
            return 1;
         }
         else if (_Rank.Equals("Jack") || _Rank.Equals("Queen") || _Rank.Equals("King"))
         {
            return 10;
         }
         else
         {
            return Int32.Parse(_Rank);
         }
      }
      //will return a string of a combination of the suit and rank
      public string GetFace()
      {
         return "" + _Rank + " of " + _Suit;
      }

   }
   class Deck
   {
      public Card[] Cards { get; set; }
      public Random RandomGenerator { get; set; }
      private int NumOfCardsDrawn;//keeps track of the amount of cards drawn 
      //constructor
      public Deck()
      {
         InitializeCards();
         RandomGenerator = new Random();
      }
      private void InitializeCards()
      {
         Cards = new Card[52];

         int index = 0;
         //initializes the cards in the Cards array
         foreach (String rank in Card.ValidRanks())
         {
            foreach (String suit in Card.ValidSuits())
            {
               Cards[index++] = new Card(suit, rank);


            }
         }

      }
      //draws a card from the deck
      public Card DrawCard()
      {
         //resets the deck once all the cards are drawn
         if (NumOfCardsDrawn == 52)
         {
            InitializeCards();
         }
         int randomNumber;
         //generates a random number to a select a card as until that number element in the card array has not yet been drawn
         do
         {
            randomNumber = RandomGenerator.Next(0, 52);

         } while (Cards[randomNumber] == null);
         //stores the card before setting it to null
         Card drawnCard = Cards[randomNumber];
         //adds to the number of cards draw to ensure that the deck will be reset once all 52 cards are shuffled
         NumOfCardsDrawn++;
         Cards[randomNumber] = null;
         return drawnCard;

      }


   }

   class Game
   {
      private Boolean _UserWon;
      private Boolean _ComputerWon;
      private int _UserScore;
      private int _ComputerScore;
      private Deck Deck;

      // Game class constructor 
      public Game()
      {
         _UserWon = false;//will be set to true when the user wins
         _ComputerWon = false;//will be set to true when the house wins
         _UserScore = 0;
         _ComputerScore = 0;
         //creates a new deck
         Deck = new Deck();
      }
      public Boolean UserWon
      {
         get { return _UserWon; }
      }

      public Boolean ComputerWon
      {
         get { return _ComputerWon; }
      }
      public int UserScore
      {
         get { return _UserScore; }
      }

      public int ComputerScore
      {
         get { return _ComputerScore; }
      }

      //generates a move for the computer
      public void ComputerMove()
      {
         Card card = Deck.DrawCard();//draws a card
         if (card.Rank.Equals("Jack") || card.Rank.Equals("Queen") || card.Rank.Equals("King"))
         {
            _ComputerScore += 10;
         }
         else if (card.Rank.Equals("Ace"))
         {
            _ComputerScore += 1;
         }
         else
         {
            _ComputerScore += Convert.ToInt32(card.Rank);//adds the card value to the score
         }

         Console.WriteLine("The house draws " + card.GetFace() + " ,and has " + _ComputerScore + " points now ");
         //checks if either side won
         if (_ComputerScore == 21)
         {
            _ComputerWon = true;
         }
         if (_ComputerScore > 21)
         {
            _UserWon = true;
         }

      }
      //generates a move for the user
      public void UserMove()
      {

         Card card = Deck.DrawCard();//draws a card
         if (card.Rank.Equals("Jack") || card.Rank.Equals("Queen") || card.Rank.Equals("King"))
         {
            _UserScore += 10;
         }
         else if (card.Rank.Equals("Ace"))
         {
            _UserScore += 1;
         }
         else
         {
            _UserScore += Convert.ToInt32(card.Rank);//adds the card value to the score
         }

         Console.WriteLine("You draw " + card.GetFace() + " ,and have " + _UserScore + " points now ");
         if (_UserScore == 21)
         {
            _UserWon = true;
         }
         if (_UserScore > 21)
         {
            _ComputerWon = true;
         }

      }
   }
   class Program
   {

      static void Main(string[] args)
      {

         Game game = new Game();
         Console.WriteLine("Welcome to Blackjack!");
         game.ComputerMove();
         game.ComputerMove();
         // i did not check if anyone won here although it said to in your instructions, because it's not possible for either side to have won(because the face cards all equal 10 and ace can only equal 1 not 11)
         game.UserMove();
         game.UserMove();
         if (game.ComputerWon == true)
         {
            Console.WriteLine("BLACKJACK! The house wins!");

         }
         else if (game.UserWon == true)
         {
            Console.WriteLine("BLACKJACK! You won!");

         }
         else
         {
            string toDraw;
            //allows the user to draw cards aslog as he wants to and there is no winner
            do
            {
               Console.WriteLine("Would you like to draw another card(Y/N)?");
               toDraw = Console.ReadLine();
               if (toDraw.Equals("Y"))
               {
                  game.UserMove();

               }


            } while ((!(game.ComputerWon == true)) && (!(game.UserWon == true)) && (toDraw.Equals("Y")));
            if (game.ComputerWon == true)
            {
               Console.WriteLine("BLACKJACK! The house wins!");
            }
            else if (game.UserWon == true)
            {
               Console.WriteLine("BLACKJACK! You won!");
            }
            else
            {
               while (game.ComputerScore <= 17)
               {
                  game.ComputerMove();
                  if (game.ComputerWon == true)
                  {
                     Console.WriteLine("BLACKJACK! The house wins!");
                  }
                  else if (game.UserWon == true)
                  {
                     Console.WriteLine("BLACKJACK! You won!");
                  }

               }
            }




         }
         Console.ReadLine();

      }



   }

}

