using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    internal class Apple : Product
    {
        public Apple(string name, int calories, int volume) : base(name, calories, volume)
        {

        }
        
        public static Apple add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calories + apple2.Calories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Apple", calories, volume);
            return apple;
        }

        public static Apple operator+ (Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calories + apple2.Calories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Apple", calories, volume);                   
            return apple;
        }

        public static Apple operator- (Apple apple1, int volume)
        {
            var apple = new Apple("Apple", apple1.Calories, apple1.Volume + volume);
            return apple;
        }

        public static bool operator ==(Apple apple1, Apple apple2)
        {
            return apple1.Name == apple2.Name;
        }
        public static bool operator !=(Apple apple1, Apple apple2)
        {
            return false;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
