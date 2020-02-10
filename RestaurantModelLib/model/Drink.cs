using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModelLib.model
{
    public class Drink
    {
        // instance fields
        private String _name;
        private String _typeOfDrink;
        private bool _isAlcoholic;
        private double _price;
        

        // Propertie
        public string Name
        {
            get => _name;
            set => _name = value;
        }

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

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        // Constructor
        public Drink():this("dummy","somedrink", true, 0.0)
        {
        }

        public Drink(string name, string typeOfDrink, bool isAlcoholic, double price)
        {
            _name = name;
            _typeOfDrink = typeOfDrink;
            _isAlcoholic = isAlcoholic;
            _price = price;
        }

        // To String
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeOfDrink)}: {TypeOfDrink}, {nameof(IsAlcoholic)}: {IsAlcoholic}, {nameof(Price)}: {Price}";
        }
    }
}
