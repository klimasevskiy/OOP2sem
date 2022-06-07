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
    internal class Elipse : Point
    {
        private double r;
        private double R;
        public Elipse() { this.SetX(0); this.SetY(0); this.SetR(1); this.Setr(1); }

        public Elipse(double x, double y, double R, double r) { this.SetX(x); this.SetY(y); this.SetR(R); this.Setr(r); }

        public void SetR(double value) 
        {
            if(value > 0)
                this.R = value; 
            else
                this.R = 1;
        }
        public void Setr(double value) {
            if (value > 0)
                this.r = value;
            else
                this.r = 1;
        }
        public double Square()
        {
            return Math.Round(Math.PI * r * R, 2);
        }

        public void ElipseDisplay()
        {
            Console.WriteLine($"Elipse with center in O({GetX()};{GetY()}) r = {r} and R = {R}\nSquare = {Square()}");
        }
    }
}
