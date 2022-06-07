using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Rectangle
    {
        private Pair pair;
        public class Pair
        {
            private double first;
            private double second;

            public Pair()
            {
                first = 0;
                second = 0;
            }
            public Pair(double first, double second)
            {
                this.first = first;
                this.second = second;
            }
            public Pair(Pair p)
            {
                this.first = p.first;
                this.second = p.second;
            }
            public double GetFirst()
            {
                return this.first;
            }
            public double GetSecond()
            {
                return this.second;
            }
            public void SetFirst(double f)
            {
                this.first = f;
            }
            public void SetSecond(double s)
            {
                this.second = s;
            }
            public bool Init(double f, double s)
            {
                if (f > 0 && s > 0)
                {
                    SetFirst(f);
                    SetSecond(s);
                    return true;
                }
                return false;
            }
            public void Display()
            {
                Console.WriteLine("First: {0}, Second: {1}", first, second);
            }
            public void Read()
            {
                double f;
                double s;
                do
                {
                    Console.Write("First = ");
                    f = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Second = ");
                    s = Convert.ToDouble(Console.ReadLine());
                } while (!Init(f, s));
            }
            public static void Doutok(Pair a)
            {
                Console.WriteLine($"Добуток {a.first} * {a.second} = {a.first * a.second}");
            }
        }
        public double Perimeter(Pair a)
        {
            return ((a.GetFirst() + a.GetSecond()) * 2);
        }
        public double Square(Pair a)
        {
            return (a.GetFirst() * a.GetSecond());
        }
        public void Display(Pair a)
        {
            Console.WriteLine($"Периметр = {Perimeter(a)}\nПлоща = {Square(a)}");
        }
    }
}
