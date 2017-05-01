using System;

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


		for (int i = 0; i < H; i++)
		{
			string ROW = (Console.ReadLine());



			string line = "";
			int pos = ((char.ToUpper(T[0]) - 65) * 4);
			for (int c = pos; c < pos + L; c++)
			{
				line += ROW[c];
			}
			Console.WriteLine(line);


		}

		// Write an action using Console.WriteLine()
		// To debug: Console.Error.WriteLine("Debug messages...");

		//Console.WriteLine("answer");
	}
}