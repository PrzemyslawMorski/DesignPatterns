using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Singleton
{
    public class ScrabbleLetters
    {
        private readonly IEnumerable<string> letters = new[]
        {
            "a", "a", "a", "a", "a", "a", "a", "a", "a", "b", "b", "c", "c", "d", "d", "d", "d", "e", "e", "e", "e",
            "e", "e",
            "e", "e", "e", "e", "e", "e", "f", "f", "g", "g", "g", "h", "h", "i", "i", "i", "i", "i", "i", "i", "i",
            "i", "j",
            "k", "l", "l", "l", "l", "m", "m", "n", "n", "n", "n", "n", "n", "o", "o", "o", "o", "o", "o", "o", "o",
            "p", "p",
            "q", "r", "r", "r", "r", "r", "r", "s", "s", "s", "s", "t", "t", "t", "t", "t", "t", "u", "u", "u", "u",
            "v", "v",
            "w", "w", "x", "y", "y", "z"
        };

        private static readonly object syncLock = new object();


        public IEnumerable<string> Letters
        {
            get { return letters; }
            private set { }
        }


        private static ScrabbleLetters instance;

        public static ScrabbleLetters Instance
        {
            get
            {
                lock (syncLock)
                {
                    return instance ?? (instance = new ScrabbleLetters());
                }
            }
            private set { }
        }

        private ScrabbleLetters()
        {
        }
    }
}