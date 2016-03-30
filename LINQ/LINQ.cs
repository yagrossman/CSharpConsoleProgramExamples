using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   class LINQ
   {
      static void Main(string[] args)
      {
         List<Car> myCars = new List<Car>() {
                new Car() { Make = "BMW", Model= "550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009},
                new Car() { Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010},
                new Car() { Make="BMW", Model = "745li", Color=CarColor.Black, StickerPrice=75000, Year=2008},
                new Car() {Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=25000, Year=2008},
                new Car() {Make="BMW", Model="55i", Color=CarColor.Black, StickerPrice=57000, Year=2010}
            };

         //LINQ query to filter only bmws && 2010 models from our Car list myCars
         /*
         var bmws = from car in myCars
                    where car.Make == "BMW"
                    && car.Year == 2010
                    select car;
         */
         /*
         var bmws = from car in myCars        //this creates new anonymous collection with these 3 types
                      where car.Make == "BMW"
                      select new { car.Make, car.Model, car.Year };*/

         /* //here we can order the cars by their year
         var orderedCars = from car in myCars
                           orderby car.Year descending //default is ascending
                           select car;
                           */

         //same examples using the "method" syntax instead of the LINQ query syntax (same exact output)
         //var _bmws = myCars.Where(p => p.Year == 2010).Where(p => p.Make == "BMW"); //pass in lambda expressions
         //var _orderedCars = myCars.OrderByDescending(p => p.Year);
         //var sum = myCars.Sum(p => p.StickerPrice);
         //Console.WriteLine(sum);

         foreach (var car in myCars) //var is implicit and lets the compiler figure out which type to use
            Console.WriteLine("{0} - {1} - {2}", car.Make, car.Model, car.Year);

         Console.ReadLine();
      }
   }

   class Car
   {
      public string Make { get; set; }
      public string Model { get; set; }
      public int Year { get; set; }
      public double StickerPrice { get; set; }
      public CarColor Color { get; set; }
   }

   enum CarColor
   {
      White,
      Black,
      Red,
      Blue,
      Yellow
   }

}
