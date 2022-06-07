using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    public class Square : Root, Print
    {
        private double a;
        private double b;
        private double c;
        private double result_a;
        private double result_b;

        public Square(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get => a;
            set { }
        }

        public double B
        {
            get => b;
            set { }
        }

        public double C
        {
            get => c;
            set { }
        }

        public double Result()
        {
            throw new NotImplementedException();
        }

        public double Result_A()
        {
            double d = 0;
            d = Math.Pow(b, 2) - (4 * a * c);
            result_a = (-b + Math.Sqrt(d)) / (2 * a);
            return result_a;
        }

        public double Result_B()
        {
            double d = 0;
            d = Math.Pow(b, 2) - (4 * a * c);
            result_b = (-b - Math.Sqrt(d)) / (2 * a);
            return result_b;
        }

        public void Print()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Square Result_A: ");
            Console.WriteLine(Math.Round(Result_A(), 2));
            Console.Write("Square Result_B: ");
            Console.WriteLine(Math.Round(Result_B(), 2));
            Console.WriteLine("-------------------------");
        }
    }
}
