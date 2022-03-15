using System;

namespace laba2
{
    class Program
    {
        /*Написати програму, яка за допомогою генератора випадкових чисел формує вказаний
        масив – такий, що значення його елементів належать заданому діапазону.Обчислити
        кількість та суму тих елементів, які задовольняють вказаному критерію; а також замінити
        нулями ці елементи.*/

        /*Діапазон значень елементів масиву: (-50,...,15)
        Одновимірний масив a із 24 елементів цілого типу.
        Критерій – всі від’ємні або непарні.*/
        static void Main()
        {
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
        }
    }
}
