using System;
using System.Diagnostics;

// Problem 479: Given an integer n, where n exists within the range [1,8], return the largest palidrome made by the product of two n-digit numbers.

namespace LeetCode
{
	class Problem479_LargestPalindrome
	{
		public int LargestPalindrome(int n)
		{
			long biggest = 0;
			int upper = (int)(Math.Pow(10, n));
			int lower = upper / 10;

			// Generating multiples of all 2-digit numbers
			for (int i = lower; i < upper; i++)
			{
				for (int j = lower; j < i; j++)
				{
					long product = i * j; // finding product e.g. 123
					if (product > upper * upper) break;

					var productString = product.ToString(); // type casting product to string => '123'
					char[] productArray = productString.ToCharArray(); // turning string to character array => ['1','2','3']
					Array.Reverse(productArray); // reversing array => ['3','2','1']
					var productReversed = new string(productArray);
					if (!(product > biggest && product.ToString() == productReversed)) continue;
					biggest = product;
				}
			}
			return (int)(biggest % 1337);
		}

		public static void Main(string[] args)
		{
			Console.Clear();
			var timer = Stopwatch.StartNew();

			var palin = new Problem479_LargestPalindrome();
			var drome = palin.LargestPalindrome(3);
			timer.Stop();
			Console.WriteLine(drome);
			Console.WriteLine("\nExecution time: " + timer.ElapsedMilliseconds + " ms");
		}
	}
}
