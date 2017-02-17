using System;
using System.Collections.Generic;
using System.Diagnostics;

class Problem506_RelativeRanks
{
	public string[] FindRelativeRanks(int[] nums)
	{
		// Initializing string array to return values
		string[] numString = new string[nums.Length];
		IList<int> numsList = new List<int>();

		for (int i = 0; i < nums.Length; i++)
		{
			numsList.Add(nums[i]);
		}
		// Sorting numbers in integer input array
		Array.Sort(nums);

		// Assigning ranks using a descending loop
		for (int i = nums.Length - 1; i >= 0; i--)
		{
			// Insight: the relative rank is the difference between the array length and the counter assigning ranks according to highest score
			int rank = nums.Length - i;

			// Assigning highest 3 scores at the beginning of the sorted array
			if (i == nums.Length - 1) { numString[numsList.IndexOf(nums[i])] = "Gold Medal"; }
			else if (i == nums.Length - 2) { numString[numsList.IndexOf(nums[i])] = "Silver Medal"; }
			else if (i == nums.Length - 3) { numString[numsList.IndexOf(nums[i])] = "Bronze Medal"; }
			// Assinging relative ranking based on position in the sorted array
			else { numString[numsList.IndexOf(nums[i])] = rank.ToString(); }
		}
		Console.WriteLine("Relative rankings: {0}", string.Join(",", numString));

		return numString;
	}

	public static void Main(string[] args)
	{
		var timer = Stopwatch.StartNew();
		int[] nums = { 5, 2, 6, 12, 1, 9 }; // Output: { "4", "5", "Bronze Medal", "Gold Medal", "6", "Silver Medal" }
		var problem506 = new Problem506_RelativeRanks();
		problem506.FindRelativeRanks(nums);

		timer.Stop();
		Console.WriteLine("Execution time: {0} ms", timer.ElapsedMilliseconds);
	}
}
