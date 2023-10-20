using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        delegate bool IsTeenAger(Student stud);

        public static void Main()
        {
            Student[] studentArray = {
            new Student() { Id = 1, Name = "John", Age = 18 },
            new Student() { Id = 2, Name = "Steve",  Age = 21 },
            new Student() { Id = 3, Name = "Bill",  Age = 25 },
            new Student() { Id = 4, Name = "Ram" , Age = 20 },
            new Student() { Id = 5, Name = "Ron" , Age = 31 },
            new Student() { Id = 6, Name = "Chris",  Age = 17 },
            new Student() { Id = 7, Name = "Rob",Age = 19  },
        };

            IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger(stud));

            IsTeenAger isTeenAger2 = s => s.Age > 12 && s.Age < 20;

            Student stud2 = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger2(stud));



            Console.ReadLine();

        }
    }
}
