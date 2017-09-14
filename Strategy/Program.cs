using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            System.Console.WriteLine(dog.Sound);
            var bird = new Bird();
            var animal = new Animal();
        }
    }
}
