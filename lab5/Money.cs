using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Money
    {
        private int n500;
        private int n200;
        private int n100;
        private int n50;
        private int n20;
        private int n10;
        private int n5;
        private int n1;

        public Money()
        {
            n500 = 0;
            n200 = 0;
            n100 = 0;
            n50 = 0;
            n20 = 0;
            n10 = 0;
            n5 = 0;
            n1 = 0;
        }
        public Money(int n500, int n200, int n100, int n50, int n20, int n10, int n5, int n1)
        {
            this.n500 = n500;
            this.n200 = n200;
            this.n100 = n100;
            this.n50 = n50;
            this.n20 = n20;
            this.n10 = n10;
            this.n5 = n5;
            this.n1 = n1;
        }
        public Money(Money c)
        {
            this.n500 = c.n500;
            this.n200 = c.n200;
            this.n100 = c.n100;
            this.n50 = c.n50;
            this.n20 = c.n20;
            this.n10 = c.n10;
            this.n5 = c.n5;
            this.n1 = c.n1;
        }
        #region Seters
        public void Set500(int n500)
        {
            this.n500 = n500;
        }

        public void Set200(int n200)
        {
            this.n200 = n200;
        }

        public void Set100(int n100)
        {
            this.n100 = n100;
        }

        public void Set50(int n50)
        {
            this.n50 = n50;
        }

        public void Set20(int n20)
        {
            this.n20 = n20;
        }

        public void Set10(int n10)
        {
            this.n10 = n10;
        }

        public void Set5(int n5)
        {
            this.n5 = n5;
        }

        public void Set1(int n1)
        {
            this.n1 = n1;
        }
        #endregion
        
        #region Geters
        public int Get500(int n500)
        {
            return n500;
        }

        public int Get200(int n200)
        {
            return n200;
        }

        public int Get100(int n100)
        {
            return n100;
        }

        public int Get50(int n50)
        {
            return n50;
        }

        public int Get20(int n20)
        {
            return n20;
        }

        public int Get10(int n10)
        {
            return n10;
        }

        public int Get5(int n5)
        {
            return n5;
        }

        public int Get1(int n1)
        {
            return n1;
        }
        #endregion

        public bool Init(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            if (a>=0 && b>=0 && c>=0 && d >= 0 && e >= 0 && f >= 0 && g >= 0 && h >= 0)
            {
                n500 = a;
                n200 = b;
                n100 = c;
                n50 = d;
                n20 = e;
                n10 = f;
                n5 = g;
                n1 = h;
                return true;
            }
            else
            {
                return false;
            }

        }


        public void Read()
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            int g;
            int h;
            do
            {
                Console.Write("Купюр по 500 : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 200 : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 100 : ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 50 : ");
                d = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 20 : ");
                e = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 10 : ");
                f = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 5 : ");
                g = Convert.ToInt32(Console.ReadLine());
                Console.Write("Купюр по 1 : ");
                h = Convert.ToInt32(Console.ReadLine());

            } while (!Init(a, b, c, d, e, f, g, h));
            Console.WriteLine($" Загалом: {Realmoney()}");
            Console.WriteLine();
        }
        public void Display()
        {
            Console.WriteLine($"Money:\n500: {n500}\n200: {n200}\n100: {n100}\n50: {n50}" +
                                $"\n20: {n20}\n10: {n10}\n5: {n5}\n1: {n1}\nЗагалом: {Realmoney()} грн\n");
        }

        private float Realmoney()
        {
            return (500 * n500 + 200 * n200 + 100 * n100 + 50 * n50 + 20 * n20 + 10 * n10 + 5 * n5 + n1);
        }
        #region Operators
        public static Money operator +(Money a, Money b)
        {
            return new Money(a.n500 + b.n500, 
                             a.n200 + b.n200, 
                             a.n100 + b.n100, 
                             a.n50 + b.n50, 
                             a.n20 + b.n20, 
                             a.n10 + b.n10, 
                             a.n5 + b.n5, 
                             a.n1 + b.n1);
        }
        public static Money operator /(Money a, Money b)
        {
            if (a.Realmoney() > b.Realmoney())
            {
                return new Money(a.n500 / b.n500,
                             a.n200 / b.n200,
                             a.n100 / b.n100,
                             a.n50 / b.n50,
                             a.n20 / b.n20,
                             a.n10 / b.n10,
                             a.n5 / b.n5,
                             a.n1 / b.n1);
            }
            else if (a.Realmoney() < b.Realmoney())
            {
                return new Money(b.n500 / b.n500,
                             b.n200 / a.n200,
                             b.n100 / a.n100,
                             b.n50 / a.n50,
                             b.n20 / a.n20,
                             b.n10 / a.n10,
                             b.n5 / a.n5,
                             b.n1 / a.n1);
            }
            else return new Money(1, 1, 1, 1, 1, 1, 1, 1);
        }
        public static Money operator *(Money a, Money b)
        {
            return new Money(a.n500 * b.n500,
                             a.n200 * b.n200,
                             a.n100 * b.n100,
                             a.n50 * b.n50,
                             a.n20 * b.n20,
                             a.n10 * b.n10,
                             a.n5 * b.n5,
                             a.n1 * b.n1);
        }
#endregion
        public void Drib(Money a, Money b)
        {
            double x;
            Console.Write("Дрiб: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Перша сума подiлена на дрiб: {a.Realmoney()}/{x} = {Math.Round(a.Realmoney() / x, 2)}");
            Console.WriteLine($"Друга сума подiлена на дрiб: {b.Realmoney()}/{x} = {Math.Round(b.Realmoney() / x, 2)}");

        }

    }
}
