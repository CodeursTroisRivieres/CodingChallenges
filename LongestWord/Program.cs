using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LongestWord
{
    public class Program
    {
        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }

        public static string LongestWord(string sentence)
        {
            string onlyLettersAndNumbers = Regex.Replace(sentence, "[^a-zA-Z0-9 ]", string.Empty);

            return onlyLettersAndNumbers
                .Split(" ")
                .GroupBy(x => x.Length)
                .OrderByDescending(g => g.Key)
                .Select(g => g.First())
                .FirstOrDefault();
        }
    }
}
