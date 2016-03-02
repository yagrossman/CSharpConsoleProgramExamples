using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
   class StringsDateTime
   {
      static void Main(string[] args)
      {//String Stuff
         string myString = "Go to your c:\\ drive";
         myString = "My \"so called\" life";
         myString = "What if i need \n a new line?";
         myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");
         myString = string.Format("{0:C}", 123.45);//Dollars and Cents
         myString = string.Format("{0:N}", 13456789);//Number with commas and decimal point 
         myString = string.Format("{0:P}", .123);//Percentage
         myString = string.Format("Phone Number: {0:(###)-###-####}", 7737912243);//Custom Format for phone numbers

         myString = " That summer we took threes accross the board  ";
         //myString = myString.Substring(5, 14);
         //myString = myString.ToUpper();
         //myString = myString.Replace(" ", "--");
         myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
         Console.WriteLine(myString);

         //DateTime Stuff
         DateTime myValue = DateTime.Now;
         Console.WriteLine(myValue.ToString());
         Console.WriteLine(myValue.ToShortDateString());
         Console.WriteLine(myValue.ToShortTimeString());
         Console.WriteLine(myValue.ToLongDateString());
         Console.WriteLine(myValue.ToLongTimeString());
         Console.WriteLine(myValue.AddDays(3).ToLongDateString());
         Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
         Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
         Console.WriteLine(myValue.Month.ToString());
         Console.WriteLine(myValue.DayOfWeek.ToString());

         DateTime myBirthday = new DateTime(1990, 7, 16);
         Console.WriteLine(myBirthday.ToShortDateString());

         DateTime myBday = DateTime.Parse("07/16/1990");
         TimeSpan myAge = DateTime.Now.Subtract(myBday);
         Console.WriteLine(myAge.TotalDays);

         Console.ReadLine();
      }
   }
}
