// Дан список чисел, необходимо удалить все вхождения числа 20 из него и вывести его в обратном порядке.

using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> nums = new List<string>();

        nums.Add("20");
        nums.Add("1");
        nums.Add("3");
        nums.Add("4");
        nums.Add("5");
        nums.Add("20");
        nums.Add("6");
        nums.Add("7");

        foreach(string num in nums)
        {
            Console.WriteLine(num);
        } 
        
        nums.Reverse();
        
        nums.RemoveAll(Equals20);
        Console.WriteLine();

        Console.WriteLine("Вывели список в обратном порядке и удалили 20:");
        Console.WriteLine();
       foreach(string num in nums)
        {
            Console.WriteLine(num);
        } 
    }

    // Search predicate returns true if a string ends in "20".
   private static bool Equals20(String s)
    {
        return s.ToLower().Equals("20");
    } 
   
}

         


