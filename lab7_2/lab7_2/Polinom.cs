using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    internal class Polinom
    {
        private int[] massive;
        public Polinom()
        {
            massive = new int[0];
        }
        public Polinom(int n, int num)
        {
            massive = new int[n];
            massive = FillUpMassive(n, num);
        }
        public Polinom(int[] a)
        {
            this.massive = a;
        }

        private int[] FillUpMassive(int n, int num)
        {
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = num + 1;
            }
            return temp;
        }

        public double Calculate(double x)
        {
            double result = massive[0];
            for (int i = 1; i < massive.Length; i++)
            {
                result += massive[i] * Math.Pow(x, i);
            }
            return result;
        }
        public static Polinom operator +(Polinom a, Polinom b)
        {
            if (a.massive.Length != b.massive.Length)
            {
                Console.WriteLine("ERROR POLINOMS HAVE DIFFERENT AMOUNT OF ELEMENTS");
                return new Polinom();
            }
            else
            {
                int[] result = new int[a.massive.Length];
                for (int i = 0; i < a.massive.Length; i++)
                {
                    result[i] = a.massive[i] + b.massive[i];
                }
                    return new Polinom(result);
            }
        }
        public static Polinom operator -(Polinom a, Polinom b)
        {
            if (a.massive.Length != b.massive.Length)
            {
                Console.WriteLine("ERROR POLINOMS HAVE DIFFERENT AMOUNT OF ELEMENTS");
                return new Polinom();
            }
            else
            {
                int[] result = new int[a.massive.Length];
                for (int i = 0; i < a.massive.Length; i++)
                {
                    result[i] = a.massive[i] - b.massive[i];
                }
                return new Polinom(result);
            }
        }
        public static bool operator *(Polinom a, Polinom b)
        {
            if(a.Calculate(5) > b.Calculate(5))
            {
                Console.WriteLine("A>B");
            }
            else if(a.Calculate(5) < b.Calculate(5))
            {
                Console.WriteLine("A<B");
            }
            else if(a.Calculate(5) == b.Calculate(5))
            {
                Console.WriteLine("A=B");
            }
            return true;
        }
        public void Print()
        {
            Console.Write(massive[0] + ", ");
            for (int i = 1; i < massive.Length; i++)
            {
                Console.Write(massive[i] + "x^" + i + ", ");
            }
            Console.WriteLine();
        }
    }
}
