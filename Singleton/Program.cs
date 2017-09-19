using System;
using System.Linq;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var scrabbleLetters = ScrabbleLetters.Instance;
            Console.WriteLine($"Instance ID: {scrabbleLetters.GetHashCode()}");
//            foreach (var letter in scrabbleLetters.Letters)
//            {
//                Console.WriteLine(letter);
//            }

            var secondInstanceScrabbleLetters = ScrabbleLetters.Instance;
            Console.WriteLine($"Instance ID: {secondInstanceScrabbleLetters.GetHashCode()}");
        }
    }
}