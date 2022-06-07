/*Створити клас Polinom для роботи з многочленами до 100-ої степені.
Коефіцієнти мають бути представлені масивом з 100 елементів-коефіцієнтів.
Молодша степінь має менший індекс (нульова степінь – нульовий індекс). Розмір
масиву задається як аргумент конструктора ініціалізації. Реалізувати арифметичні
операції та операції порівняння, обчислення значення поліному для заданого
значення х, диференціювання, інтегрування.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    internal class Program
    {
        
        public static void Main(String[] args)
        {
            Polinom a = new Polinom(5, 0);
            a.Print();

            Console.WriteLine();
            
            Polinom b = new Polinom(5, 2);
            b.Print();
            
            Console.WriteLine();
            
            Polinom c = a+b;
            Console.Write("A+B = ");   
            c.Print();

            c = a-b;
            Console.Write("A-B = ");
            c.Print();

            Console.WriteLine();
            
            bool isEqual = a*b;
            
            Console.WriteLine("For x = 5 Polinom = " + a.Calculate(5));
        }
    }
}