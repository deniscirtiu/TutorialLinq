using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		// Student collection
		IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
		};

		var sortedStudents = from s in studentList
							 orderby s.StandardID descending, s.Age descending
							 select new
							 {
								 StudentName = s.StudentName,
								 Age = s.Age,
								 StandardID = s.StandardID
							 };

		sortedStudents.ToList().ForEach(s => Console.WriteLine($"Student Name: {s.StudentName}, Age: {s.Age}, StandardID: {s.StandardID}"));

		Console.ReadKey();
	}
}

public class Student
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
	public int StandardID { get; set; }
}