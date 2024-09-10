using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        //Using Array
        int[] nums = { 5, 1, 8, 2, 3, 0 };
        var res = from a in nums
                  where a < 3
                  orderby a
                  select a;
        foreach (var num in res)
        {
            Console.WriteLine(num);
        }


        //Using List
        List<int> nums = new List<int> { 5, 1, 8, 2, 3, 0 };
        
        // LINQ query
        var res = from a in nums
                  where a < 3
                  orderby a
                  select a;

        foreach (var num in res)
        {
            Console.WriteLine(num);
        }

        //Using Dictionary
        Dictionary<int, string> nums = new Dictionary<int, string>
        {
            { 5, "Five" },
            { 1, "One" },
            { 8, "Eight" },
            { 2, "Two" },
            { 3, "Three" },
            { 0, "Zero" }
        };

        var res = from kvp in nums
                  where kvp.Key < 4
                  orderby kvp.Value
                  select kvp;

        foreach (var kvp in res)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }


        //Using LinkedList ,Similarly can be used for Stack And Queue
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(5);
        linkedList.AddLast(1);
        linkedList.AddLast(8);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(0);

        var res = from item in linkedList
                  where item < 3
                  orderby item
                  select item;

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }


        //Using two arrays
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
        Console.WriteLine("Pairs where a < b:");
        foreach (var pair in pairs)
        {
            Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
        }



        //Finiding even and odd numbers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ Query: Even numbers
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // LINQ Method : Odd numbers
        var oddNumbers = numbers.Where(num => num % 2 != 0);

        Console.WriteLine("Odd numbers:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }


    }
}



