using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sparky = new Dog();
            var tweety = new Bird();

            System.Console.WriteLine("Sparky: " + sparky.TryToFly());
            System.Console.WriteLine("Tweety: " + tweety.TryToFly());

            sparky.FlyingType = new ItFlys();

            System.Console.WriteLine("Sparky: " + sparky.TryToFly());
        }
    }
}
