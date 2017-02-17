using System;
using System.Collections.Generic;
using System.Diagnostics;

// Problem 448: Given an array with inputs ranging from [1,n], n being the array length, some elements appear twice,
// some only once, and some not at all. Find the missing elements.

class Problem448_FindDisappearedNumbers
{
	public IList<int> FindDisappearedNumbers(int[] nums)
	{
		// Initializing hash map to uniquely assing values in the array, discarding duplicates
		HashSet<int> numsList = new HashSet<int>();
		IList<int> disappearedList = new List<int>();

		// Filling list
		for (int i = 0; i < nums.Length; i++)
		{
			numsList.Add(nums[i]);
		}

		for (int j = 1; j <= nums.Length; j++)
		{
			// If the input array is missing an input from [1,n], append it to the return list
			if (!numsList.Contains(j)) disappearedList.Add(j);
		}
		return disappearedList;
	}

	public static void Main(string[] args)
	{
		Stopwatch timer = Stopwatch.StartNew();

		int[] nums = { 1, 5, 3, 4, 4, 8, 5, 7 };

		var numsList = new Problem448_FindDisappearedNumbers();
		IList<int> disappeared = numsList.FindDisappearedNumbers(nums);
		Console.WriteLine("Input list: {0}\nMissing numbers: {1}", string.Join(",", nums), string.Join(",", disappeared));

		timer.Stop();
		Console.WriteLine("Execution time: {0} ms", timer.ElapsedMilliseconds);
	}
}
