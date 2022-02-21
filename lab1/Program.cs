using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
			double x; // вхідний параметр
			double y; // результат обчислення виразу
			double A = 0; // проміжний результат - функціонально стала частина виразу
			double B = 0; // проміжний результат - функціонально змінна частина виразу

			Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

			A = 2 / x + Math.Abs(x);

			// спосіб 1: розгалуження в скороченій формі
			if (x < 0)
				B = 1 + 4 * Math.Pow(x, 2);
			if (0 <= x && x <= 2)
				B = Math.Pow(Math.Exp(x) + Math.Abs(x), 2);
			if (x > 2)
				B = 5 * Math.Sin(x * x + 1);
			
			y = A + B;

			Console.WriteLine("\n");
			Console.WriteLine("1) y = " + y + "\n");

			// спосіб 2
			if (x < 0)
				B = 1 + 4 * Math.Pow(x, 2);
			else
				if (x > 2)
				B = 5 * Math.Sin(x * x + 1);
			else
				B = Math.Pow(Math.Exp(x) + Math.Abs(x), 2);

			y = A + B;

			Console.WriteLine("2) y = " + y + "\n");
		}
	}
}
