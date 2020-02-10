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
    }
}
