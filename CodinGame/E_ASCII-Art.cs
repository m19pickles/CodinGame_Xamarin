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
		string T = Console.ReadLine();
		var letterList = new List<string>();


		for (int i = 0; i < H; i++)
		{
			string ROW = (Console.ReadLine());

			//split each line on the required number of char to create array of characters
			int startPos = 0;
			for (int letterGroup = 0; letterGroup < ROW.Length / L; letterGroup++)
			{
				if (i == 0)
				{
					letterList.Add(ROW.Substring(startPos, L));
				}
				else
				{
					letterList[letterGroup] += ROW.Substring(startPos, L);
				}
				startPos += L;
			}
		}
		//Find indexs of letters
		var stringReconstruct = new List<string>();
		foreach (char c in T)
		{
			int pos = 26;
			if (char.ToUpper(c) >= 65 && char.ToUpper(c) <= 90)
			{
				pos = char.ToUpper(c) - 65;
			}
			//Creates list of only letters needed
			stringReconstruct.Add(letterList[pos]);
		}
		string[] charOutPut = new string[H];
		int lineNum = 0;
		for (int i = 0; i < H; i++)
		{
			for (int j = 0; j < stringReconstruct.Count; j++)
			{
				charOutPut[i] += stringReconstruct[j].Substring(lineNum, L);
			}
			lineNum += L;
			//print output
			Console.WriteLine("{0}", charOutPut[i]);
		}

	}
}