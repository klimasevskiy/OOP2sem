using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            /*Написати програму для обчислення і виводу на екран значення змінної y – функції від
            аргументу x. x, y – дійсні числа.
            Значення x ввести з клавіатури. В одній програмі реалізувати два способи: 1)
            використання лише команд розгалуження в скороченій формі та 2) використання лише
            команд розгалуження в повній формі – отримані результати мають збігатися.
            */
            double x; // вхідний параметр
            double y; // результат обчислення виразу
            double A = 0; // проміжний результат - функціонально стала частина виразу
            double B = 0; // проміжний результат - функціонально змінна частина виразу
            Console.WriteLine("Завдання 1:");
            Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

            A = 2 / x + Math.Abs(x);

            // спосіб 2
            if (x < 0)
                B = 1 + 4 * Math.Pow(x, 2);
            else
                if (x > 2)
                B = 5 * Math.Sin(x * x + 1);
            else
                B = Math.Pow(Math.Exp(x) + Math.Abs(x), 2);

            y = A + B;

            Console.WriteLine($" y =  {y}  \n");

            //Завдання 2
            /*Написати програму для обчислення і виводу на екран значення функції F від
            аргументу x. a, b, c – дійсні числа.
            Значення a, b, c, x ввести з клавіатури. В одній програмі реалізувати два способи: 1)
            використання лише команд розгалуження в скороченій формі та 2) використання лише
            команд розгалуження в повній формі – отримані результати мають збігатися.
            */
            Console.WriteLine("Завдання 2:");

            double a; // вхідний параметр
            double b; // вхідний параметр
            double c; // вхідний параметр
            double F = 0; // результат обчислення виразу

            Console.WriteLine("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c = "); c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

            // спосіб 2: розгалуження в повній формі
            if (a < 0 && c != 0)
                F = a * x * x + b * x + c;

            else
                if (a > 0 && c == 0)
                F = (-a) / (x - c);

            else
                F = a * (x + c);

            Console.WriteLine($" F =  {F}");

            //Завдання 3
            /*Написати програму, яка обчислює значення вказаного виразу за допомогою циклів. В
            одній програмі слід вивести результати обчислень за 4-ма способами:
            1) while(...) { ... }
            2) do{ ... } while(...);
            3) for(...; ...; n++) {... }
            4) for(...; ...; n--) {... }
            Всі 4 результати мають збігатися.
            */
            Console.WriteLine("Завдання 3:");

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
            Console.WriteLine($"1) S =  {S}");

            S = 0;
            i = k;
            do
            {
                S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
                i++;
            } while (i <= N);
            Console.WriteLine($"2) S =  {S}");

            S = 0;
            for (i = k; i <= N; i++)
            {
                S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
            }
            Console.WriteLine($"3) S =  {S}");

            S = 0;
            for (i = N; i >= k; i--)
            {
                S += (1.0 / i + Math.Sqrt(1 + Math.Sin(i) * Math.Sin(i)));
            }
            Console.WriteLine($"4) S =  {S}");


            //Завдання 4
            /*Обчислити і вивести на екран в вигляді таблиці значення функції F на інтервалі від
            X_поч до X_кін з кроком dX.
            a, b, c – дійсні числа.
            Значення a, b, c, X_поч, X_кін, dX ввести з клавіатури.*/

            Console.WriteLine("Завдання 4:");
            double xp, xk, dx;

            Console.WriteLine("xp = "); xp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("xk = "); xk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dx = "); dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = "); a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = "); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c = "); c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------");
            Console.WriteLine("|     x     |     F     |");
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

                Console.WriteLine($"|      {x}  |      {F}  |");
                x += dx;
            }
            Console.WriteLine("---------------------------");

        }
    }
}
