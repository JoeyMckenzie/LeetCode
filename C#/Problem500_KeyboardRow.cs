using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

class Problem500_KeyboardRow
{
  public bool oneRowTyped(string word)
  {
  		char[] row1Array = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
  		char[] row2Array = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
  		char[] row3Array = { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
  		char[] letters = word.ToCharArray();

  		bool row1Typed = true;
  		bool row2Typed = true;
  		bool row3Typed = true;
  		bool canBeTyped = true;

  		for (int i = 0; i < letters.Length; i++)
  		{
  			for (int j = 0; j < row1Array.Length; j++)
  			{
  				if (!row1Array.Contains(letters[i])) { row1Typed = false; break; }
  			}
  			for (int k = 0; k < row2Array.Length; k++)
  			{
  				if (!row2Array.Contains(letters[i])) { row2Typed = false; break; }
  			}

  			for (int l = 0; l < row3Array.Length; l++)
  			{
  				if (!row3Array.Contains(letters[i])) { row3Typed = false; break; }
  			}

  			if (!row1Typed && !row2Typed && !row3Typed) { canBeTyped = false; break; }
  		}
  		return canBeTyped;
  	}

  	public string[] FindWords(string[] words)
  	{
  		IList<string> oneRowWords = new List<string>();

  		for (var i = 0; i < words.Length; i++)
  		{
  			if (oneRowTyped(words[i])) oneRowWords.Add(words[i]);
  		}

  		return oneRowWords.ToArray();
  	}

  	public static void Main(string[] args)
  	{
  		Stopwatch timer = Stopwatch.StartNew();
  		string[] words = { "Hello", "Alaska", "Dad", "Peace" };
  		var keyboards = new Problem500_KeyboardRow();
  		string[] findWords = keyboards.FindWords(words);
  		Console.WriteLine("findWords: {0}", string.Join(",", findWords));


  		timer.Stop();
  		Console.WriteLine("\nExecution time: {0} ms", timer.ElapsedMilliseconds);
  	}
}
