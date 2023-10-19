using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		// string collection
		IList<string> stringList = new List<string>() {
			"C# Tutorials",
			"VB.NET Tutorials",
			"Learn C++",
			"MVC Tutorials" ,
			"Java"
		};

		// LINQ Method Syntax
		var result = stringList.Where(s => s.Contains("Tutorials"));


		foreach (var str in result)
		{
			Console.WriteLine(str);
		}

		Console.ReadKey();
	}
}