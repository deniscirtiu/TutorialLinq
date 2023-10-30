using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
        IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
        IList<string> emptyList = new List<string>();

        Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
        //Added orderby Descending
        Console.WriteLine("1st Even Element in intList: {0}", intList.OrderByDescending(s => s).FirstOrDefault(i => i % 2 == 0));

        Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

        Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());
        Console.ReadKey();

    }
}