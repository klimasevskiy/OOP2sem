using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			double x; // вхідний аргумент
			double a; // вхідний параметр
			double b; // вхідний параметр
			double c; // вхідний параметр
			double F = 0; // результат обчислення виразу

			Console.WriteLine("a = "); a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("b = "); b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("c = "); c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

			// спосіб 1: розгалуження в скороченій формі
			if (a < 0 && c != 0)
				F = a * x * x + b * x + c;

			if (a > 0 && c == 0)
				F = (-a) / (x - c);

			if (!(x < 0 && b != 0) && !(x > 0 && b == 0))
				F = a * (x + c);

			Console.WriteLine("1) F = " + F);

			// спосіб 2: розгалуження в повній формі
			if (a < 0 && c != 0)
				F = a * x * x + b * x + c;

			else
				if (a > 0 && c == 0)
				F = (-a) / (x - c);

			else
				F = a * (x + c);

			Console.WriteLine("2) F = " + F);
		}
	}
}
