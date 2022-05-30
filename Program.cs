using System;

namespace Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var redApple = new Apple("Red apple", 100, 100);
            var greenApple = new Apple("Green apple", 90, 110);

            var sumApple = Apple.add(redApple, greenApple);
            var sumApple2 = redApple + greenApple;
            Console.WriteLine(sumApple);
            Console.WriteLine("============");
            Console.WriteLine(sumApple2);
            Console.WriteLine("============");
            Console.WriteLine(redApple);
            Console.WriteLine("=================");
            Console.WriteLine(redApple == redApple);
        }
    }
}
