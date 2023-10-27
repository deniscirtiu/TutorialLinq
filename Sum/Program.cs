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

        var sumOfAge = studentList.Sum(s => s.Age);

        Console.WriteLine("Sum of all student's age: {0}", sumOfAge);

        var totalAdults = studentList.Sum(s => {

            if (s.Age >= 18)
                return 1;
            else
                return 0;
        });

        var totalAdults2 = studentList.Where(s => s.Age >= 18).Count();

        Console.WriteLine($"Total Adult Students: {totalAdults}");
        Console.WriteLine($"Total Adult Students: {totalAdults2}");
        Console.ReadLine();
    }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}