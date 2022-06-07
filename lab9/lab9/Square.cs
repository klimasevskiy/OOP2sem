using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Square : Root
    {
        private double c;
        private double result_a;
        private double result_b;

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

        public Square(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Result_A()
        {
            double d = 0;
            d = Math.Pow(b, 2) - (4 * a * c);
            result_a = (-b + Math.Sqrt(d)) / (2 * a);
            return result_a;
        }

        public override double Result_B()
        {
            double d = 0;
            d = Math.Pow(b, 2) - (4 * a * c);
            result_b = (-b - Math.Sqrt(d)) / (2 * a);
            return result_b;
        }

        public override void Print()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Square Result_A: ");
            Console.WriteLine(Math.Round(result_a, 2));
            Console.Write("Square Result_B: ");
            Console.WriteLine(Math.Round(result_b, 2));
            Console.WriteLine("-------------------------");
        }

        public override double Result()
        {
            throw new NotImplementedException();
        }
    }
}
