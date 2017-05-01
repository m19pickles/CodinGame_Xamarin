using System;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
	static void Main(string[] args)
	{
		int L = int.Parse(Console.ReadLine());
		int H = int.Parse(Console.ReadLine());
		string T = Console.ReadLine().ToUpper();


		for (int i = 0; i < H; i++)
		{
			string ROW = (Console.ReadLine());
			//loop through all chars in string
			foreach (char c in T)
			{
				//determine start pos
				int index = c;
				if (index >= 'A' && index <= 'Z')
				{
					index = c - 'A';
				}
				else
				{
					index = 'Z' - 'A' + 1;
				}
				//print output
				Console.Write(ROW.Substring(index * L, L));
			}
			Console.WriteLine();
		}
	}
}