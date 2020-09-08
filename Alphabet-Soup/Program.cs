using System;
using System.Linq;

namespace Alphabet_Soup
{
    class MainClass
    {
        public static string AlphabetSoup(string input)
        {
            return new string(input.ToCharArray().OrderBy(c => c).ToArray());

            //var x = input
            //    .Select(c => (c - 65) % 32)
            //    .OrderBy(i => i)
            //    .ToString();

            //foreach (char c in input)
            //{
            //    int weight = ((int)c - 65) % 32;
            //}

            //return new string(input.OrderBy(c => c).ToArray());
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(AlphabetSoup(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
