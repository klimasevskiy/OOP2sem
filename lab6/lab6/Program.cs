/*Створити клас Pair (пара чисел); визначити методи зміни полів та обчислення  добутку чисел. 
Визначити клас-контейнер Rectangle (прямокутник), що містить поле «пара  чисел» – пара чисел описує сторони.  
Визначити методи обчислення периметру та площі прямокутника 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab6
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Rectangle rect = new Rectangle();
            Rectangle.Pair pair = new Rectangle.Pair(1, 2);
            pair.Read();
            pair.Display();
            Rectangle.Pair.Doutok(pair);
            rect.Square(pair);
            rect.Perimeter(pair);
            rect.Display(pair);
        }
    }
}
