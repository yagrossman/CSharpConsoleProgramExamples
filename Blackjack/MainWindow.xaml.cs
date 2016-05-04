using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private string UserWonMessage = "You won!!! :-)\nDo you want to continue playing?";
      private string ComputerWonMessage = "Computer won :-(\nDo you want to continue playing?";
      private Game myGame;
      enum GameStatus
      {
         Continue,
         Exit,
         Restart
      }
      public MainWindow()
      {
         InitializeComponent();
      }
      private string cardImageFilename(Card card)
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
      private Image GetImageForCard(Card card)
      {
         Image image = new Image();
         image.Margin = new Thickness(2);
         image.Source = new BitmapImage(new Uri(cardImageFilename(card), UriKind.Relative));
         return image;
      }
      private void StartGame()
      {
         ClearTheBoard();

         myGame = new Game();

         ComputerMove();
         ComputerMove();

         switch (CheckGameStatus())
         {
            case GameStatus.Exit:
               Environment.Exit(0);
               break;
            case GameStatus.Restart:
               ClearTheBoard();
               return;
         }

         MyMove();
         MyMove();

         switch (CheckGameStatus())
         {
            case GameStatus.Exit:
               Environment.Exit(0);
               break;
            case GameStatus.Restart:
               ClearTheBoard();
               return;
         }
      }
      private void ClearTheBoard()
      {
         ComputerCards.Children.Clear();
         UserCards.Children.Clear();
         computerScoreTextBox.Text = null;
         userScoreTextBox.Text = null;
      }
      private void ComputerMove()
      {
         ComputerCards.Children.Add(GetImageForCard(myGame.ComputerMove()));
         computerScoreTextBox.Text = myGame.ComputerScore.ToString();
      }
      private void MyMove()
      {
         UserCards.Children.Add(GetImageForCard(myGame.UserMove()));
         userScoreTextBox.Text = myGame.UserScore.ToString();
      }
      private GameStatus CheckGameStatus()
      {
         string message = null;
         if (myGame.ComputerWon)
         {
            message = ComputerWonMessage;
         }
         else if (myGame.UserWon)
         {
            message = UserWonMessage;
         }

         if (message != null)
         {
            return DisplayGameOverMessage(message);
         }

         return GameStatus.Continue;
      }
      private static GameStatus DisplayGameOverMessage(string message)
      {
         MessageBoxResult userAnswer = MessageBox.Show(message, "Game Over", MessageBoxButton.YesNo);
         if (userAnswer == MessageBoxResult.No)
         {
            return GameStatus.Exit;
         }
         else
         {
            return GameStatus.Restart;
         }
      }
      private void newGameButton_Click(object sender, RoutedEventArgs e)
      {
         StartGame();
      }

      private void hitButton_Click(object sender, RoutedEventArgs e)
      {
         MyMove();

         switch (CheckGameStatus())
         {
            case GameStatus.Exit:
               Environment.Exit(0);
               break;
            case GameStatus.Restart:
               ClearTheBoard();
               return;
         }

         ComputerMove();

         switch (CheckGameStatus())
         {
            case GameStatus.Exit:
               Environment.Exit(0);
               break;
            case GameStatus.Restart:
               ClearTheBoard();
               return;
         }
      }

      private void passButton_Click(object sender, RoutedEventArgs e)
      {
         if (myGame.ComputerScore > myGame.UserScore)
         {
            switch (DisplayGameOverMessage(ComputerWonMessage))
            {
               case GameStatus.Exit:
                  Environment.Exit(0);
                  break;
               case GameStatus.Restart:
                  ClearTheBoard();
                  return;
            }
         }
         else
         {
            ComputerMove();
         }

         switch (CheckGameStatus())
         {
            case GameStatus.Exit:
               Environment.Exit(0);
               break;
            case GameStatus.Restart:
               ClearTheBoard();
               return;
         }
      }
   }
}
