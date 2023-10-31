using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> oneElementList = new List<int>() { 7 };
        IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
        IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
        IList<string> emptyList = new List<string>();

        Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
        Console.WriteLine("The only element in oneElementList: {0}",
                     oneElementList.SingleOrDefault());

        Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

        Console.WriteLine("The only element which is less than 10 in intList: {0}",
                     intList.Single(i => i < 10));

        //Followings throw an exception
        //Console.WriteLine("The only Element in intList: {0}", intList.Single());
        //Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());
        //Console.WriteLine("The only Element in emptyList: {0}", emptyList.Single());

        Console.ReadLine();
    }
}