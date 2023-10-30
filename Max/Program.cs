using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Steve" , Age = 15 }
        };

        var studentWithLongName = studentList.Max();
        var olderStudent = studentList.OrderByDescending(s => s.Age).FirstOrDefault();


        Console.WriteLine("Student with long name: Student ID: {0}, Student Name: {1}", studentWithLongName.StudentID, studentWithLongName.StudentName);
        //Age max 
        Console.WriteLine($"Student with max Age  : Student ID: {olderStudent.StudentID}, Student Name: {olderStudent.StudentName}");
        Console.ReadKey();

    }
}

public class Student : IComparable<Student>
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public int StandardID { get; set; }

    public int CompareTo(Student other)
    {
        if (this.StudentName.Length >= other.StudentName.Length)
            return 1;

        return 0;
    }
}