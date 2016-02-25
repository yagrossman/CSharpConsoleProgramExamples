using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Needed for IO

namespace Input_File_Example
{
   class Program
   {
      static void Main(string[] args)
      {


         StreamReader myReader = new StreamReader("Values.txt");
         string line = "";

         while (line != null)
         {
            line = myReader.ReadLine();
            if (line != null)
               Console.WriteLine(line);
         }

         myReader.Close();
         Console.ReadLine();
      }

   }
}
