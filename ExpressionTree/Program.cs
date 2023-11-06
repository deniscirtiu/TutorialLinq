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
            Console.ReadKey();
        }
    }
}
