using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModelLib.model
{
    public class Dish
    {
        // instance field
        private String _name;
        private String _typeOfDish;
        private double _price;

        // properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string TypeOfDish
        {
            get => _typeOfDish;
            set => _typeOfDish = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        // Constructor
        public Dish():this("dummy","someDish", 0.0)
        {
        }

        public Dish(string name, string typeOfDish, double price)
        {
            _name = name;
            _typeOfDish = typeOfDish;
            _price = price;
        }

        // To String
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeOfDish)}: {TypeOfDish}, {nameof(Price)}: {Price}";
        }
    }
}
