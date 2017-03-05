using System;
using System.Diagnostics;

public class Problem492_ConstructRectangle
{
	public int[] ConstructRectangle(int area)
	{
		// Initializing minimal difference to check againsy
		int minimal_diff = area;
		int minimal_length = 0;
		int minimal_width = 0;

		// Setting upper bound for width
		int maxWidth = (int)Math.Ceiling(Math.Sqrt(area));

		// Iterating through factors
		for (int width = 1; width <= maxWidth; width++)
		{
			// Calculating length of rectangle (casting to int)
			int length = (int)(area / width);

			// Checking possible length/width combinations and iterating until minimum
			// distance is fond
			if (area % length == 0 && length * width == area && length >= width)
			{
				int diff = length - width;
				if (diff < minimal_diff)
				{
					minimal_diff = diff;
					minimal_length = length;
					minimal_width = width;
				}
			}
		}

		// Initializing return array
		int[] dimensions = { minimal_length, minimal_width };

		return dimensions;
	}

	public static void Main(string[] args)
	{
		Stopwatch timer = Stopwatch.StartNew();

		var test = new Problem492_ConstructRectangle();
		test.ConstructRectangle(36);

		timer.Stop();

		Console.WriteLine("\nExecution time: {0} ms", timer.ElapsedMilliseconds);
	}
}
