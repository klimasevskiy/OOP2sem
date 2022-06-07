using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Money(1, 1, 1, 1, 1, 1, 1, 1);
            var b = new Money(3, 2, 1, 2, 2, 5, 1, 1);
            a.Display();
            b.Read();

            Console.WriteLine("Оператор +");
            var c = new Money();
            c = a + b;
            c.Display();
            Console.WriteLine("Оператор /");
            var d = new Money();
            d = a / b;
            d.Display();
            Console.WriteLine("Оператор *");
            var e = new Money();
            e = a * b;
            e.Display();
            Console.WriteLine("Дробове");
            a.Drib(a, b);
        }
    }
}
