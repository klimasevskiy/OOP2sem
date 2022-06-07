using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    public class Linear : Root, Print
    {
        private double a;
        private double b;
        private double result;

        public double A
        {
            get => a;
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException($"{nameof(value)} mustn't be 0!");
                }
            }
        }

        public double B
        {
            get => b;
            set { }
        }

        public Linear(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Result()
        {
            result = -(b / a);
            return result;
        }

        public double Result_A()
        {
            throw new NotImplementedException();
        }

        public double Result_B()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Linear Result: ");
            Console.WriteLine(Result());
            Console.WriteLine("-------------------------");
        }
    }

}
