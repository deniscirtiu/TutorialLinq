using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 12 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };

        var teenAgerStudents = from s in studentList.GetTeenAgerStudents()
                               select s;


        foreach (Student teenStudent in teenAgerStudents)
            Console.WriteLine("Student Name: {0}", teenStudent.StudentName);
        Console.ReadKey();
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}

public static class EnumerableExtensionMethods
{
    public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
    {

        foreach (Student std in source)
        {
            Console.WriteLine("Accessing student {0}", std.StudentName);

            if (std.Age > 12 && std.Age < 20)
                yield return std;
        }
    }
}
