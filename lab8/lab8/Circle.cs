/*Створити клас точка, що має координати. Визначити класи еліпсів і кіл.
Визначити ієрархію типів. Визначити функції виведення, конструктори, деструктори,
обчислення площі.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Circle : Point
    {
        private double radius;
        public Circle() { this.SetX(0); this.SetY(0); this.SetR(1); }

        public Circle(double x, double y, double r) { this.SetX(x); this.SetY(y); this.SetR(r); }

        public void SetR(double value)
        {
            if (value > 0)
                this.radius = value;
            else
                this.radius = 1;
        }

        public double Square()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public void CircleDisplay()
        {
            Console.WriteLine($"Circle with center in O({GetX()};{GetY()}) and radius = {radius}\nSquare = {Square()}");
        }

    }
}
