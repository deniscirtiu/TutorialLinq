using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ParameterExpression pe = Expression.Parameter(typeof(Student), "s");

            MemberExpression me = Expression.Property(pe, "Age");

            ConstantExpression constant = Expression.Constant(18, typeof(int));

            BinaryExpression body = Expression.GreaterThanOrEqual(me, constant);

            var ExpressionTree = Expression.Lambda<Func<Student, bool>>(body, new[] { pe });

            Console.WriteLine("Expression Tree: {0}", ExpressionTree);

            Console.WriteLine("Expression Tree Body: {0}", ExpressionTree.Body);

            Console.WriteLine("Number of Parameters in Expression Tree: {0}",
                                            ExpressionTree.Parameters.Count);

            Console.WriteLine("Parameters in Expression Tree: {0}", ExpressionTree.Parameters[0]);

            Console.WriteLine("===============Another method of teenager===============");
            //try with querry form the site and try to generate on my own
            IList<Student> Students = new List<Student>
            {
                new Student() { Age = 11, StudentId = 1, StudentName = "DNSSS" },
                new Student() { Age = 20, StudentId = 2, StudentName = "DNSS1" },
                new Student() { Age = 40, StudentId = 3, StudentName = "DNSS2" }
            };

            var query = from s  in Students
                        where s.Age >= 18
                        select s.StudentName;

            query.ToList().ForEach(n => Console.WriteLine(n));
            //Console.WriteLine(query);

            Console.ReadKey();
        }
    }
}
