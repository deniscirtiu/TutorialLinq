using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Student std = new Student() { StudentID = 1, StudentName = "Bill" };

        IList<Student> studentList1 = new List<Student>() { std };

        IList<Student> studentList2 = new List<Student>() { std };

        bool isStudentsEqual = studentList1.SequenceEqual(studentList2); // returns true

        Console.WriteLine(isStudentsEqual);

        Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };

        Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

        IList<Student> studentList3 = new List<Student>() { std1 };

        IList<Student> studentList4 = new List<Student>() { std2 };

        isStudentsEqual = studentList3.SequenceEqual(studentList4); // returns false

        Console.WriteLine(isStudentsEqual);

        Console.ReadLine();
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
}