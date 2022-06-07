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
    internal class Vector
    {
        private int N;
        private int[] numbers;

        public Vector()
        {
            this.N = 0;
            this.numbers = new int[N];
        }
        public Vector(Vector a)
        {
            this.N = a.N;
            this.numbers = a.numbers;
        }

        public void Create()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Please, input amount of numbers:"); n = Convert.ToInt32(Console.ReadLine());
            } while ((n <= 0));
            this.N = n;
            //this.numbers = new int[N];
            Fill();
        }

        public void Fill()
        {
            this.numbers = new int[N];
            for (int i = 0; i < this.N; i++)
            {
                numbers[i] = i+1;
            }
        }
        public void InputVect()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Number {i + 1} = "); numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Display()
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", numbers[j]); 
            }
        }
        public static int operator *(Vector a, Vector b)
        {
            int scalar = 0;
            if (a.N == b.N)
            {
                for (int i = 0; i < a.N; i++)
                {
                    scalar += a.numbers[i] * b.numbers[i];
                }
                //Console.WriteLine($"Скалярний добуток = {scalar}");
            }
            return scalar;
        }
        public static double operator !(Vector a)
        {
            double norm = 0;
            double tmp = 0;
            for(int i = 0; i < a.N; i++)
            {
                tmp +=Math.Pow(a.numbers[i], 2);
            }
            norm = Math.Sqrt(tmp);
            return norm;
        }
        public static bool operator ^(Vector a, Vector b)
        {
            if(!a > !b)
            {
                Console.WriteLine($"Вектор a > Вектор b");
            }
            if (!a < !b)
            {
                Console.WriteLine($"Вектор a < Вектор b");
            }
            if (!a == !b)
            {
                Console.WriteLine($"Вектор a = Вектор b");
            }
            return true;
        }
    }
}
