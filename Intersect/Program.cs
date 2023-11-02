using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
		IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

		var result = strList1.Intersect(strList2);

		foreach (string str in result)
			Console.WriteLine(str);
		Console.ReadLine();
	}
}