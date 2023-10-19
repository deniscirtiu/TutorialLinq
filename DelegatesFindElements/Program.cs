using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesFindElements
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }


    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
        };
            //filter
            Student[] students = StudentExtension.where(studentArray, delegate (Student std) {
                return std.Age > 12 && std.Age < 20;
            });
            //show it to console
            Console.WriteLine("Students in age between 12 and 20");

            foreach (Student std in students)
            {
                if (std != null)
                {
                    Console.WriteLine("Student : {0}", std.StudentName);
                }
            }
            //added for another filter
            Student[] students2 = StudentExtension.where(studentArray, delegate (Student std) {
                return std.StudentName == "Bill";
            });

            //show it to console
            Console.WriteLine("\n\nStudents who's name is Bill:");

            foreach (Student std in students2)
            {
                if (std != null)
                {
                    Console.WriteLine("Student : {0} And Age: {1}", std.StudentName,std.Age);
                }
            }
            Console.WriteLine("\n\n\n");//new filter with lambda expressions
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            Console.WriteLine("Student Bill: {0}\nAge:{1}",bill.StudentName,bill.Age);
            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine("Student id 5 : {0}\nAge:{1}", student5.StudentName, student5.Age);
            Console.ReadKey();
        }
    }
}

