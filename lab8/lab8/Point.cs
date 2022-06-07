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
    internal class Point
    {
        private double x;
        private double y;

        public Point() { this.x = 0; this.y = 0; }
        public Point(double a, double b) { this.x = a; this.y = b; }
        public Point(Point p) { this.x = p.x; this.y = p.y; }
        public double GetX() { return this.x; }
        public double GetY() { return this.y; }
        public void SetX(double value) { this.x = value; }
        public void SetY(double value) { this.y = value; }
        public void Display()
        {
            Console.WriteLine($"Point({x};{y})");
        }
    }
}
