using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }
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
		IList<string> stringList2 = new List<string>();


		foreach (string s in stringList)
		{
			if(s.Contains("Tutorials"))
				stringList2.Add(s);
		}



        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
        foreach (var str in stringList2)
        {
            Console.WriteLine(str);
        }

        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
        var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                  .ToList<Student>();

        foreach(var student in teenAgerStudents) { 
            Console.WriteLine(student.StudentName); 
            Console.WriteLine(student.Age); 
        }

        Console.ReadKey();
	}
}