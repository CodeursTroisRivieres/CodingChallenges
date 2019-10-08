//https://coderbyte.com/information/First%20Reverse

using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static void Main()
    {
        string toReverse = Console.ReadLine();
        Console.WriteLine(Reverse(toReverse));
    }

    public static string Reverse(string toReverse)
    {
        List<char> list = toReverse.ToList();
        list.Reverse();
        return new string(list.ToArray());
    }
}