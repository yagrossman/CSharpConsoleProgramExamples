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

namespace WpfEvent
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         //clickMeButton.Click += button_OtherClick;
      }

      private void clickMeButton_Click(object sender, RoutedEventArgs e) //event handler code
      {
         helloWorldLabel.Content = "Hello World!!!";
      }
      //private void button_OtherClick(object sender, RoutedEventArgs e)
      //{
      //   helloAgainLabel.Content = "Hello Again!!!";
      //}
   }
}
