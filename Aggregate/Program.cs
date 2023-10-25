using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

        var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

        Console.WriteLine(commaSeperatedString);
        Console.ReadKey();
    }
}