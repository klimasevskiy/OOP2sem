/*Описати клас, який представляє вектор із N цілих чисел.
Реалізувати операції
• скалярного добутку векторів;
• порівняння векторів;
• обчислення норми вектора (корінь із суми квадратів елементів).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector a = new Vector();
            a.Create();
            a.Fill();
            a.Display();

            Vector b = new Vector();
            b.Create();
            b.InputVect();
            Console.WriteLine($"Скалярний добуток = {a*b}");
            Console.WriteLine($"Норма вектора а = {Math.Round(!a, 3)}");
            bool istrue = a ^ b;
        }
    }
}
