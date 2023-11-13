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

		IList<Standard> standardList = new List<Standard>() {
			new Standard(){ StandardID = 1, StandardName="Standard 1"},
			new Standard(){ StandardID = 2, StandardName="Standard 2"},
			new Standard(){ StandardID = 3, StandardName="Standard 3"}
		};

		var studentsWithStandard = from stad in standardList
								   join s in studentList
								   on stad.StandardID equals s.StandardID
								   into sg
								   from std_grp in sg
								   orderby stad.StandardName, std_grp.StudentName
								   select new
								   {
									   StudentName = std_grp.StudentName,
									   StandardName = stad.StandardName
								   };


		foreach (var group in studentsWithStandard)
		{
			Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
		}
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

public class Standard
{

	public int StandardID { get; set; }
	public string StandardName { get; set; }
}
