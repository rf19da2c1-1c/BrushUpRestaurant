using System;

namespace RestaurantModelLib.model
{
    public class MenuItem
    {
        // Instance fields
        protected String _name;
        protected double _price;


        // properties
        public string Name
        {
            get => _name;
            set
            {
                // always make the check before setting the value
                if (string.IsNullOrEmpty(value) || value.Length < 3 || 60 < value.Length)
                {
                    throw new ArgumentException($"Name is not between 3-60 characters it was {value}");
                }

                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                // always make the check before setting the value
                if (value < 0)
                {
                    throw new ArgumentException($"Price is not equal or above zero but it was {value}");
                }

                _price = value;
            }
        }

        // constructor
        public MenuItem():this("dummy",0.0)
        {
        }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}";
        }
    }
}