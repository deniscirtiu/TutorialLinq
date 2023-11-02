using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

		var newList = strList.Take(2);

		foreach (var str in newList)
			Console.WriteLine(str);

        Console.WriteLine("=========TakeWhile=========");

		IList<string> strList2 = new List<string>() { "Three", "Four", "Five", "Hundred" };

		var newList2 = strList2.TakeWhile(s => s.Length > 4);

		foreach (var str in newList)
			Console.WriteLine(str);

		Console.ReadLine();	

	}
}