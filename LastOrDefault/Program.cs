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
        //LAST
        Console.WriteLine("----------------------------LAST-------------------------------------------");
        Console.WriteLine("Last Element in intList: {0}", intList.Last());
        Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

        Console.WriteLine("Last Element in strList: {0}", strList.Last());

        Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
        
        if (emptyList.Count > 0)
            Console.WriteLine(emptyList.Last());
        //LASTORDEFAULT
        Console.WriteLine("----------------------------LAST OR DEFAULT---------------------------------");
        Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

        Console.WriteLine("Last Even Element in intList: {0}",intList.LastOrDefault(i => i % 2 == 0));

        Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

        Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());
        Console.ReadKey();

    }
}