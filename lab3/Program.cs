using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
			int k = 1, N, i;

			double S;

			Console.WriteLine("N = "); N = Convert.ToInt32(Console.ReadLine());

			S = 0;
			i = k;
			while (i <= N)
			{
				S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
				i++;
			}
			Console.WriteLine("S = " + S);

			S = 0;
			i = k;
			do
			{
				S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
				i++;
			} while (i <= N);
			Console.WriteLine("S = " + S);

			S = 0;
			for (i = k; i <= N; i++)
			{
				S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
			}
			Console.WriteLine("S = " + S);

			S = 0;
			for (i = N; i >= k; i--)
			{
				S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
			}
			Console.WriteLine("S = " + S);

		}
	}
}
