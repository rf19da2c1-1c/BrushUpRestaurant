using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModelLib.model
{
    public class Drink : MenuItem
    {
        // instance fields
        private String _typeOfDrink;
        private bool _isAlcoholic;


        // Properties
        public string TypeOfDrink
        {
            get => _typeOfDrink;
            set => _typeOfDrink = value;
        }

        public bool IsAlcoholic
        {
            get => _isAlcoholic;
            set => _isAlcoholic = value;
        }

        // Constructor
        public Drink():this("dummy","somedrink", true, 0.0)
        {
        }

        public Drink(string name, string typeOfDrink, bool isAlcoholic, double price):base(name,price)
        {
            _typeOfDrink = typeOfDrink;
            _isAlcoholic = isAlcoholic;
        }

        // To String
        public override string ToString()
        {
            return base.ToString() + $", {nameof(TypeOfDrink)}: {TypeOfDrink}, {nameof(IsAlcoholic)}: {IsAlcoholic}";
        }
    }
}
