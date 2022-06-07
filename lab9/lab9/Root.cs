using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public abstract class Root
    {
        public double a;
        public double b;

        abstract public double Result();
        abstract public double Result_A();
        abstract public double Result_B();
        abstract public void Print();
    }
}
