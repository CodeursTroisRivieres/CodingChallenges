using System;
using System.Collections.ObjectModel;
using System.Linq;

public class Kata
{
    private static readonly ReadOnlyCollection<char> LowerCaseLetters;
    private static readonly ReadOnlyCollection<char> UpperCaseLetters;

    static Kata()
    {
        LowerCaseLetters = new ReadOnlyCollection<char>(Enumerable
            .Range('a', 26)
            .Select(i => (char)i)
            .ToList());

        UpperCaseLetters = new ReadOnlyCollection<char>(Enumerable
            .Range('A', 26)
            .Select(i => (char)i)
            .ToList());
    }

    public static string Rot13(string message)
    {
        return new String(message
            .Select(ToRot13)
            .ToArray());
    }

    private static char ToRot13(char c)
    {
        if (LowerCaseLetters.Contains(c))
        {
            int rot13Index = (LowerCaseLetters.IndexOf(c) + 13) % 26;
            return LowerCaseLetters.ElementAt(rot13Index);
        }

        if (UpperCaseLetters.Contains(c))
        {
            int rot13Index = (UpperCaseLetters.IndexOf(c) + 13) % 26;
            return UpperCaseLetters.ElementAt(rot13Index);
        }

        return c;
    }
}