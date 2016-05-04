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
      public MainWindow()
      {
         InitializeComponent();
      }

      private void newGameButton_Click(object sender, RoutedEventArgs e)
      {
         Game myGame = new Game();
         string cCard1 = Card.guiCard(myGame.ComputerMove());
         string cCard2 = Card.guiCard(myGame.ComputerMove());
         //add pic of cards to computer
         //image1.Source = new BitmapImage(new Uri(card1, UriKind.Relative));
         computerScoreTextBox.Text = myGame.ComputerScore.ToString();
         while (myGame.ComputerScore < 17)
         {
            myGame.ComputerMove();
            //add pic of card to computer
            computerScoreTextBox.Text = myGame.ComputerScore.ToString();
         }
         myGame.GameWinCheck();
         string uCard1 = Card.guiCard(myGame.UserMove());
         string uCard2 = Card.guiCard(myGame.UserMove());
         //add pic of cards to user
         //image3.Source = new BitmapImage(new Uri(card1, UriKind.Relative));
         userScoreTextBox.Text = myGame.UserScore.ToString();
         myGame.GameWinCheck();
      }

      private void hitButton_Click(object sender, RoutedEventArgs e)
      {
         string uCard3 = Card.guiCard(myGame.UserMove());
         myGame.GameWinCheck();
      }

      private void passButton_Click(object sender, RoutedEventArgs e)
      {

      }
   }
}
