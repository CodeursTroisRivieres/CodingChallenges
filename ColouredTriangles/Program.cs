using System;
using System.Collections.Generic;

namespace ColouredTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string Triangle(string row)
        {
            if (row.Length == 1)
            {
                return row;
            }

            var array = new List<char>();
            for (int i = 0; i < row.Length - 1; i++)
            {
                array.Add(GetColor(row[i], row[i + 1]));
            }
            return row;
        }

        private static char GetColor(char firstColor, char secondColor)
        {
            if (firstColor == secondColor)
            {
                return firstColor;
            }

            return GetOtherColor(firstColor, secondColor);
        }

        private static char GetOtherColor(char firstColor, char secondColor)
        {
            const char red = 'R';
            const char green = 'G';
            const char blue = 'B';


        }
    }
}
