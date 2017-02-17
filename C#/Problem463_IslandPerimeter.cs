using System;
using System.Diagnostics;

/*
  Problem 463: You are given a map in form of a two-dimensional integer grid where
  1 represents land and 0 represents water. Grid cells are connected
  horizontally/vertically (not diagonally). The grid is completely surrounded by water,
  and there is exactly one island (i.e., one or more connected land cells).
  The island doesn't have "lakes" (water inside that isn't connected to the water around the island).
  One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100.
  Determine the perimeter of the island.
*/

namespace LeetCode
{
  class Problem463_IslandPerimeter
  {
    /*
      The key insight to this problem is to think of any n-sided polygon
      as a collection of unit squares (1 by 1 arbitrary length squares).
      A unit square has perimeter 4, and each neighboring unit square will
      share a side, decreasing the perimeter by twice the number of shared sides,
      since each square is losing a unit of perimeter.

      The perimeter is therefore 4 * (# of unit squares) - 2 * (# of shared sides).
    */
  	public int IslandPerimeter(int[,] grid)
  	{
  		// Initializing shared sides, both right and down of current sqaure, and count number of islands
  		int numOfIslands = 0;
  		int right = 0;
  		int down = 0;

  		// Working through grid to count sides and island pieces
  		for (int i = 0; i < grid.GetLength(0); i++)
  		{
  			for (int j = 0; j < grid.GetLength(1); j++)
  			{
          // Incrementing land count if we are on land
  				if (grid[i,j] == 1)
  				{
  					numOfIslands++;
            // Incrementing shared sides if land exists right or down from the current land
  					if (i + 1 < grid.GetLength(0) && grid[i+1,j] == 1) down++;
  					if (j + 1 < grid.GetLength(1) && grid[i,j+1] == 1) right++;
  				}
  			}
  		}
  		return 4 * numOfIslands - 2 * (right + down);
  	}

  	public static void Main(string[] args)
  	{
      // Quick example: Perimeter = 16 of the following grid
  		var grid = new int[,] { {0,1,0,0}, {1,1,1,0}, {0,1,0,0}, {1,1,0,0} };
  		var timer = Stopwatch.StartNew();
  		var getPerimeter = new Problem463_IslandPerimeter();
  		Console.WriteLine("Island perimeter: {0} units", getPerimeter.IslandPerimeter(grid));

  		timer.Stop();
  		Console.WriteLine("\nExecution time: {0} ms", timer.ElapsedMilliseconds);

  	}
  }
}
