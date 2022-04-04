using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Fraction
    {
        private double chis;
        private double znam;

        public double GetChis() { return chis; }
        public double GetZnam() { return znam; }

        public bool SetChis(double value)
        {
            chis = value;
            return true;
        }
        public bool SetZnam(double value)
        {
            if (value == 0)
            {
                znam = 0;
                return false;
            }
            else
            {
                znam = value;
                return true;
            }
        }
        public bool Init(double x, double y)
        {
            return SetZnam(y) && SetChis(x);
        }

        public void Read()
        {
            double ch;
            double zn;
            do
            {
                Console.Write("Чисельник = ");
                ch = Convert.ToDouble(Console.ReadLine());
                Console.Write("Знаменник = ");
                zn = Convert.ToDouble(Console.ReadLine());
            } while (!Init(ch, zn));
        }
        public void Round(double x, double y)
        {
            for(int i=2; i <= y; i++) 
            {
                if (x % i == 0 && y % i == 0)
                {
                    x /= i;
                    y /= i;
                }
            }
            chis = x;
            znam = y;
            Console.WriteLine($"Скорочений Дрiб = {chis}/{znam}");
        }
        public double Calc(double x, double y){ return x / y; }
        public void Display()
        {
            Console.WriteLine($"Дрiб = {chis}/{znam}");
            Round(chis, znam);
            Console.WriteLine($"{chis}/{znam} = {Calc(chis, znam)}");
        }
    }
}
