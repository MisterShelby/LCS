using System;

namespace LCS
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputStrings = Console.ReadLine().Split(' ');

			var longestCommonSubsequence = LCS.LCS.Find(inputStrings[0], inputStrings[1]);

			Console.WriteLine(longestCommonSubsequence.Length);
		}
	}
}
