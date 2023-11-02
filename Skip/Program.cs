using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

		var result = strList.Skip(2);

		foreach (var str in result)
			Console.WriteLine(str);
        Console.WriteLine("============Skip While=============");
		IList<string> strList2 = new List<string>() {
											"One",
											"Two",
											"Three",
											"Four",
											"Five",
											"Six"  };

		var resultList = strList2.SkipWhile(s => s.Length < 4);

		foreach (string str in resultList)
			Console.WriteLine(str);

		Console.ReadLine();

	}
}