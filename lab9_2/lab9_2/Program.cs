/*Створити абстрактний базовий клас Root (корінь) з віртуальними методами
обчислення коренів рівняння і виведення результату на екран. Визначити похідні
класи Linear (лінійне рівняння) і Square (квадратне рівняння) з власними методами
обчислення коренів і виводу на екран.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9_2;

namespace Lab9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear:");
            Root linear = new Linear(2, 3);
            Console.WriteLine(linear.Result());
            Print linear_p = new Linear(2, 3);
            linear_p.Print();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Square:");
            Root square = new Square(9, -12, -5);
            Console.WriteLine(Math.Round(square.Result_A(), 2));
            Console.WriteLine(Math.Round(square.Result_B(), 2));
            Print square_p = new Square(9, -12, -5);
            square_p.Print();

            Console.ReadKey();
        }
    }
}
