using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

            IList<int> emptyList1 = new List<int>();

            var emptyList2 = emptyList1.DefaultIfEmpty();
            var emptyList3 = emptyList1.DefaultIfEmpty(100);

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

            Console.WriteLine("-----------------------------------Complex DefaultIfEmpty-------------------------------");

            IList<Student> emptyStudentList = new List<Student>();

            var newStudentList1 = emptyStudentList.DefaultIfEmpty(new Student());

            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student()
            {
                StudentID = 0,
                StudentName = ""
            });

            Console.WriteLine("Count: {0} ", newStudentList1.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));

            Console.WriteLine("Count: {0} ", newStudentList2.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).StudentID);

            Console.ReadLine();
        }
    }
}
