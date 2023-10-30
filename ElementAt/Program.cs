﻿using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

        IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };


        Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
        Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

        Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
        Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

        Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
        Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

        Console.WriteLine("10th Element in intList: {0} - default int value", intList.ElementAtOrDefault(9));
        Console.WriteLine("10th Element in strList: {0} - default string value (null)", strList.ElementAtOrDefault(9));


        Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(intList.ElementAt(9));
        Console.ReadKey();

    }
}