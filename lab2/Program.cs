using System;

namespace laba2
{
    class Program
    {
        static void Main()
        {
            //Завдання 1
            Console.WriteLine("Task 1");
            /*Написати програму, яка за допомогою генератора випадкових чисел формує вказаний
            масив – такий, що значення його елементів належать заданому діапазону.Обчислити
            кількість та суму тих елементів, які задовольняють вказаному критерію; а також замінити
            нулями ці елементи.*/

            /*Діапазон значень елементів масиву: (-50,...,15)
            Одновимірний масив a із 24 елементів цілого типу.
            Критерій – всі від’ємні або непарні.*/

            Random rnd = new Random();
            const int n = 24;
            int[] a = new int[n];

            int low = -50;
            int high = 15;

            for (int i = 0; i < n; i++)
                a[i] = low + rnd.Next() % (high - low + 1);

            Console.Write("a[] = {");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            int S = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
                if (a[i] < 0 || a[i] % 2 == 1)
                {
                    S += a[i];
                    k++;
                    a[i] = 0;
                }

            Console.WriteLine($"Number = {k}");
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
            Console.Write("a[] = {");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");
            }
            Console.WriteLine("}");
            Console.WriteLine();

            //Завдання 2
            Console.WriteLine("Task 2");
            /*Написати функцію, яка обчислює кількість непарних елементів одновимірного масиву
            (вектора) a із n елементів цілого типу.*/
            
            const int nt = 5;
            low = 1;
            high = 10;

            for (int i = 0; i < n; i++)
                a[i] = low + rnd.Next() % (high - low + 1);
            Console.Write("a[] = {");

            for (int i = 0; i < nt; i++)
            {
                Console.Write($"{a[i]} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            k = 0;
            for (int i = 0; i < nt; i++)
                if (a[i] % 2 == 1)
                {
                    k++;
                }
            Console.WriteLine($"Number = {k}");
            Console.WriteLine();

            //Завдання 3
            Console.WriteLine("Task 3");
            /*Написати програму, яка шукає суму мінімальних елементів по всіх рядках матриці (k * n).*/

            int rowCount = 3;
            int colCount = 3;

            int[,] ab = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    ab[i, j] = low + rnd.Next() % (high - low + 1);

            Console.WriteLine();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    Console.Write($"{ab[i, j]} \t");

                Console.WriteLine();
            }
            Console.WriteLine();

            S = 0;
            for (int i = 0; i < rowCount; i++)
            {
                int min = ab[i,0];
                for (int j = 1; j < colCount; j++)
                    if (ab[i, j] < min) min = ab[i, j];
                        S += min;

            }
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
        }
    }
}
