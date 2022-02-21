﻿using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
			double F, x, xp, xk, dx, a, b, c;

			Console.WriteLine("xp = "); xp = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("xk = "); xk = Convert.ToDouble(Console.ReadLine()); 
			Console.WriteLine("dx = "); dx = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("a = "); a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("b = "); b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("c = "); c = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("---------------------------");
			Console.WriteLine("|".PadRight(5) + "x" +"|".PadLeft(5) + "F".PadLeft(5) + "|".PadLeft(5));
			Console.WriteLine("---------------------------");

			x = xp;
			while (x <= xk)
			{
				if (a < 0 && c != 0)
					F = a * x * x + b * x + c;
				else
					if (a > 0 && c == 0)
					F = -a / (x - c);
				else
					F = a * (x + c);

				Console.WriteLine("|".PadRight(5) + x + "|".PadLeft(5) + "".PadLeft(5) + F + " |".PadLeft(5));
				x += dx;
			}
			Console.WriteLine("---------------------------");

		}
	}
}
