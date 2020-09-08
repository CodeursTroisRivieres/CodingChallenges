using System;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Rot13("Te1235@£¢{53564654`<st"));
            Console.WriteLine(Kata.Rot13("test"));
        }
    }
}
