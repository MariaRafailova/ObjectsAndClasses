using System;
using System.Linq;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];

                var randPosition = random.Next(0, words.Length);

                var temp = words[randPosition];
                words[randPosition] = currWord;
                words[i] = temp;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
