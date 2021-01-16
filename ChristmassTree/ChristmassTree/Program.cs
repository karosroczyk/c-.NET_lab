using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

public class Program
{
	static ConsoleColor color = ConsoleColor.Yellow;
	static Random _random = new Random();
	static ConsoleColor GetRandomConsoleColor()
	{
		var consoleColors = Enum.GetValues(typeof(ConsoleColor));
		return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
	}
	static void drawChristmassTreeUp(int size_max, int size)
	{
		int i = size_max;
		List<int> arr = new List<int>() { 1, 10, 20, 30, 40, 50 };
		for (int a = size_max; a > size; a--)
		{
			if (a % 2 == 1)
			{
				var val = (int)a / 2;
				for (int j = 0; j < val; j++)
					Console.Write(' ');

				for (int j = 0; j < size_max - 2 * val; j++)
				{
					if (arr.Contains(j))
					{
						Console.ForegroundColor = color;
						Console.Write('x');
						Console.ForegroundColor = ConsoleColor.DarkGreen;

					}
					else
						Console.Write('*');

				}
				arr = arr.Select(elem => { elem--; return elem; }).ToList();
				Console.WriteLine();
				i--;
			}
		}
	}

	static void drawTrunk(int size)
	{
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		var val = Math.Floor((decimal)size / 8);
		for (int i = 0; i < val; i++)
		{
			for (int j = 0; j < (int)(3 * val); j++)
				Console.Write(' ');
			for (int j = (int)(3 * val); j < (int)(5 * val); j++)
				Console.Write('*');
			for (int j = (int)(5 * val); j < size; j++)
				Console.Write(' ');
			Console.WriteLine(' ');
		}
	}

	public static void Main()
	{
		int i = 100;
		while(i != 0)
        {
			drawChristmassTreeUp(40, 20);
			drawChristmassTreeUp(40, 10);
			drawChristmassTreeUp(40, 0);
			drawTrunk(40);
			color = GetRandomConsoleColor();

			i--;
			Thread.Sleep(100);
			Console.Clear();
		}

		Console.ReadKey();
	}
}