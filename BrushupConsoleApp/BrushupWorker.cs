using System;
using RestaurantModelLib.model;

namespace BrushupConsoleApp
{
    internal class BrushupWorker
    {
        public void Start()
        {
            // Two drink objects 
            Drink d1 = new Drink();
            Drink d2 = new Drink("Coke Cola","softdrink",false,15.60);

            Console.WriteLine(d1); // whole object using tostring
            Console.WriteLine($"Name is {d1.Name} and price is {d1.Price}");

            Console.WriteLine(d2);
            d2.Price = d2.Price * 1.1; // set price 10% higher
            Console.WriteLine(d2);

            MenuCard mcard = new MenuCard();
            mcard.Drinks.Add(d1);
            mcard.Drinks.Add(d2);

            Dish dish1 = new Dish("soupe", "starter", 45.50);
            Dish dish2 = new Dish("Lasagne", "main", 105.00);
            mcard.Dishes.Add(dish1);
            mcard.Dishes.Add(dish2);

            Console.WriteLine(mcard);

            /*
             * Brushup #2
             */

            try
            {
                d1.Name = "s";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(d1);

            try
            {
                d1.Price = -35;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(d1);

            Drink d3 = new Drink();
            try
            {
                d3 = new Drink("somedrink", "redvine", true, -1);
                
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(d3);
        }
    }
}