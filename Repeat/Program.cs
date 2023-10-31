using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var intCollection = Enumerable.Repeat<int>(10, 10);
        Console.WriteLine("Total Count: {0} ", intCollection.Count());

        for (int i = 0; i < intCollection.Count(); i++)
            Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
        Console.ReadKey();
    }
}
