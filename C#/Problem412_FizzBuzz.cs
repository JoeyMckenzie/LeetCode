using System;
using System.Collections.Generic;

// Problem 412: Write a program that outputs the string representation of numbers from 1 to n.

namespace LeetCode
{
  class Problem412_FizzBuzz
  {
    public IList<string> FizzBuzz(int n)
    {
      // Initializing fizzBuzzArray using IList from Collections
      IList<string> fizzBuzzArray = new List<string>();

      for (int i = 1; i <= n; i++)
      {
        if(i % 15 == 0)
        {
          fizzBuzzArray.Add("FizzBuzz");
        } else if (i % 5 == 0) {
            fizzBuzzArray.Add("Buzz");
        } else if (i % 3 == 0) {
            fizzBuzzArray.Add("Fizz");
        } else {
            fizzBuzzArray.Add(i.ToString());
        }
      }
      return fizzBuzzArray;
    }

    public static void Main(string[] args)
    {
      var fbuzz = new Problem412_FizzBuzz();
      // Assigning n as 100
      var fbArray = fbuzz.FizzBuzz(100);
      Console.WriteLine("FizzBuzz: {0}", string.Join(",", fbArray));
    }
  }
}
