using System;
using RestaurantModelLib.model;

namespace BrushupConsoleApp
{
    internal class BrushupWorker
    {
        MenuCard mcard = new MenuCard();

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

            /*
             * Brush UP 4
             *
             */
            PopulateDrinks();
            PopulateDish();

            Console.WriteLine("Most expensice drink");
            Console.WriteLine(mcard.GetTheMostExpensiveDrink());

            Console.WriteLine("Most cheapest drink");
            Console.WriteLine(mcard.GetTheCheapestDrink());

            Console.WriteLine("cheapest redwine");
            Console.WriteLine(mcard.GetTheCheapestDrink("redwine"));

            Console.WriteLine("All type of drinks");
            Console.WriteLine(String.Join(", ", mcard.GetTypeOfDrinks()));

            Console.WriteLine("cheapest of each type");
            Console.WriteLine(String.Join(", ", mcard.GetTheCheapestDrinks()));

            Console.WriteLine("Non alcoholic drinks");
            Console.WriteLine(String.Join(", ", mcard.GetNonAlcoholicDrinks()));

            Console.WriteLine("Price of cheapest Dish");
            Console.WriteLine(mcard.PriceOfCheapestDish());

            Console.WriteLine("Price of cheapest starter");
            Console.WriteLine(mcard.PriceOfCheapestDish("starter"));
            
            Console.WriteLine("The average price of dish");
            Console.WriteLine(mcard.GetAverageDishPrice());

            Console.WriteLine("dishes starter, main, dessert");
            Console.WriteLine(String.Join(", ", mcard.GetDishOfType()));

            Console.WriteLine("2 starter");
            Console.WriteLine(String.Join(", ", mcard.GetDishes("starter",2)));

            Console.WriteLine("3 main");
            Console.WriteLine(String.Join(", ", mcard.GetDishes("main", 3)));

            Console.WriteLine("3 cheapest main");
            Console.WriteLine(String.Join(", ", mcard.GetCheapestDishes("main", 3)));



        }

        private void PopulateDish()
        {
            mcard.Dishes.Add(new Dish("ministrone", "starter", 46));
            mcard.Dishes.Add(new Dish("ribeye", "main", 158));
            mcard.Dishes.Add(new Dish("lasagne", "main", 95));
            mcard.Dishes.Add(new Dish("ice", "dessert", 38));
            mcard.Dishes.Add(new Dish("crepesuzette", "dessert", 55));
            mcard.Dishes.Add(new Dish("bananasplit", "dessert", 61));
            mcard.Dishes.Add(new Dish("scrimps", "starter", 71));
            mcard.Dishes.Add(new Dish("lopster", "starter", 137));
            mcard.Dishes.Add(new Dish("foiegras", "starter", 110));
            mcard.Dishes.Add(new Dish("chicken", "main", 98));
            mcard.Dishes.Add(new Dish("meetloaf", "main", 88));
            mcard.Dishes.Add(new Dish("lambSteak", "main", 132));

        }

        private void PopulateDrinks()
        {
            mcard.Drinks.Add(new Drink("rioja", "redwine", true, 56.8));
            mcard.Drinks.Add(new Drink("bourgone", "redwine", true, 49.5));
            mcard.Drinks.Add(new Drink("bordeaux", "redwine", true, 116.8));
            mcard.Drinks.Add(new Drink("alsace", "whitewine", true, 72.8));
            mcard.Drinks.Add(new Drink("chile", "whitewine", true, 49));
            mcard.Drinks.Add(new Drink("cablis", "whitewine", true, 93.2));
            mcard.Drinks.Add(new Drink("provance", "rosewine", true, 70));
            mcard.Drinks.Add(new Drink("perrier", "water", false, 22));
            mcard.Drinks.Add(new Drink("rioja riserva", "redwine", true, 68));
            mcard.Drinks.Add(new Drink("fanta", "softdrink", false, 18));
            mcard.Drinks.Add(new Drink("sprite", "softdrink", false, 18));

        }
    }
}