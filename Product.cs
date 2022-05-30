using System;

namespace Operator_overloading
{
    internal abstract class Product
    {
        public string Name { get;  }
        /// <summary>
        /// Каллорийность на 100 грамм продукта
        /// </summary>
        public int Calories { get; }
        /// <summary>
        /// Объем в граммах
        /// </summary>
        public int Volume { get; set; }
        public double Energy
        {
            get
            {
                return Volume * Calories / 100.0;
            }
            set
            {

            }
        }
        public Product(string name, int calories, int volume)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if(calories <= 0)
            {
                throw new ArgumentNullException(nameof(calories));
            }
            if(volume < 0)
            {
                throw new ArgumentException(nameof(volume));
            }
            Name = name;
            Calories = calories;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}.\n Calories: {Calories}.\nVolume: {Volume}.";    
        }
    }
}
