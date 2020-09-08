using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestEnemy
{
    class MainClass
    {
        public static string ClosestEnemyII(string[] strArr)
        {
            Position player = null;
            List<Position> enemies = new List<Position>();

            for (int y = 0; y < strArr.Length; y++)
            {
                for (int x = 0; x < strArr[y].Length; x++)
                {
                    char c = strArr[y][x];

                    switch (c)
                    {
                        case '0':
                            break;
                        case '1':
                            player = new Position(x, y);
                            break;
                        case '2':
                            enemies.Add(new Position(x, y));
                            break;
                    }
                }
            }

            return enemies
                .Select(e => GetDistance(e, player, strArr[0].Length, strArr.Length))
                .Min()
                .ToString();
        }

        public static int GetDistance(Position origin, Position end, int dimensionX, int dimensionY)
        {
            int absX = GetDistance(origin.X, end.X, dimensionX);
            int absY = GetDistance(origin.Y, end.Y, dimensionY);

            return absX + absY;
        }

        private static int GetDistance(int pos1, int pos2, int dimension)
        {
            int abs = Math.Abs(pos1 - pos2);
            if (abs > dimension / 2)
            {
                abs = dimension - abs;
            }

            return abs;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(ClosestEnemyII(new string[] { "0000", "0010", "0000", "0002" }));
        }

    }

    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
