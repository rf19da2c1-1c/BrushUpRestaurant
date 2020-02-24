using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModelLib.model
{
    public class MenuCard
    {
        // instance fields
        private List<Drink> _drinks;
        private List<Dish> _dishes;

        // properties - only Get
        public List<Drink> Drinks
        {
            get => _drinks;
        }

        public List<Dish> Dishes
        {
            get => _dishes;
        }

        // Constructor
        public MenuCard()
        {
            _drinks = new List<Drink>();
            _dishes = new List<Dish>();
        }

        // To String
        public override string ToString()
        {
            string drinkStr = String.Join(", ", _drinks);
            string dishStr = String.Join(", ", _dishes);

            return $"{nameof(Drinks)}: [{drinkStr}], {nameof(Dishes)}: [{dishStr}]";
        }

        /*
         * Brush up 4
         */
        public Drink GetTheMostExpensiveDrink()
        {
            Drink drink = new Drink();

            foreach (Drink d in _drinks)
            {
                if (d.Price > drink.Price)
                {
                    drink = d;
                }
            }

            return drink;
        }

        public Drink GetTheCheapestDrink()
        {
            Drink drink = new Drink();
            drink.Price = Double.MaxValue;

            foreach (Drink d in _drinks)
            {
                if (d.Price < drink.Price)
                {
                    drink = d;
                }
            }

            return drink;
        }

        public Drink GetTheCheapestDrink(String TypeOfDrink)
        {
            Drink drink = new Drink();
            drink.Price = Double.MaxValue;

            foreach (Drink d in _drinks)
            {
                if (d.Price < drink.Price && d.TypeOfDrink == TypeOfDrink)
                {
                    drink = d;
                }
            }

            return drink;
        }

        public List<String> GetTypeOfDrinks()
        {
            List<String> types = new List<string>();

            foreach (Drink d in _drinks)
            {
                if (!types.Contains(d.TypeOfDrink))
                {
                    types.Add(d.TypeOfDrink);
                }
            }

            return types;
        }

        public List<Drink> GetTheCheapestDrinks()
        {
            List<Drink> drinks = new List<Drink>();
            foreach (string typeOfDrink in GetTypeOfDrinks())
            {
                drinks.Add(GetTheCheapestDrink(typeOfDrink));
            }

            return drinks;
        }

        public List<Drink> GetNonAlcoholicDrinks()
        {
            List<Drink> drinks = new List<Drink>();
            foreach (Drink d in _drinks)
            {
                if (!d.IsAlcoholic)
                {
                    drinks.Add(d);
                }
            }

            return drinks;
        }

        public double PriceOfCheapestDish()
        {
            double cheapestPrice = Double.MaxValue;
            foreach (Dish dish in _dishes)
            {
                if (dish.Price < cheapestPrice)
                {
                    cheapestPrice = dish.Price;
                }
            }

            return cheapestPrice;
        }

        public double PriceOfCheapestDish(String TypeOfDish)
        {
            double cheapestPrice = Double.MaxValue;
            foreach (Dish dish in _dishes)
            {
                if (dish.Price < cheapestPrice && dish.TypeOfDish == TypeOfDish)
                {
                    cheapestPrice = dish.Price;
                }
            }

            return cheapestPrice;

        }

        public double GetAverageDishPrice()
        {
            double sum = 0;
            foreach (Dish dish in _dishes)
            {
                sum = sum + dish.Price;
            }

            return _dishes.Count == 0 ? 0 : sum / _dishes.Count; // return 0 if no dish in _dishes otherwice the average
        }

        public List<Dish> GetDishOfType()
        {
            List<Dish> dishes = new List<Dish>();

            List<Dish> mains = new List<Dish>();
            List<Dish> desserts = new List<Dish>();

            foreach (Dish d in _dishes)
            {
                switch (d.TypeOfDish.ToLower())
                {
                    case "starter":
                        dishes.Add(d);
                        break;
                    case "main":
                        mains.Add(d);
                        break;
                    case "dessert":
                        desserts.Add(d);
                        break;
                }
            }
            dishes.AddRange(mains);
            dishes.AddRange(desserts);

            return dishes;
        }

        public List<Dish> GetDishes(String typeOfDish, int number)
        {
            List<Dish> dishes = new List<Dish>();

            if (!(number == 0))
            {
                foreach (Dish d in _dishes)
                {
                    if (d.TypeOfDish == typeOfDish)
                    {
                        dishes.Add(d);

                        // check if number have been reached 
                        if (dishes.Count == number)
                            break;
                    }
                }
            }

            return dishes;
        }

        public List<Dish> GetCheapestDishes(String typeOfDish, int number)
        {
            List<Dish> dishes = new List<Dish>();

            if (number == 0)
                return dishes;

            // sort all dishes by price
            SortedList<double,Dish> sortDishes = new SortedList<double,Dish>();
            foreach (Dish d in _dishes)
            {
                if (d.TypeOfDish == typeOfDish)
                {
                    sortDishes.Add(d.Price, d);
                }
            }

            for (int i = 0; i < number; i++)
            {
                dishes.Add(sortDishes.Values[i]);
            }

            return dishes;
        }

    }
}
