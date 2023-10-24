using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        // Student collection
        IList<string> strList1 = new List<string>() {
            "One",
            "Two",
            "Three",
            "Four"
            };

        IList<string> strList2 = new List<string>() {
            "One",
            "Two",
            "Five",
            "Six"
            };

        var innerJoinResult = strList1.Join(// outer sequence 
                      strList2,  // inner sequence 
                      str1 => str1,    // outerKeySelector
                      str2 => str2,  // innerKeySelector
                      (str1, str2) => str1);

        /*
            from strlist1 str1 
            join strlist2 str2 on str1.str1 = str2.str2
            
         */

        foreach (var str in innerJoinResult)
        {
            Console.WriteLine("{0} ", str);
        }
        Console.ReadKey();
    }
}
