/*Створити клас точка, що має координати. Визначити класи еліпсів і кіл.
Визначити ієрархію типів. Визначити функції виведення, конструктори, деструктори,
обчислення площі.*/
namespace lab8
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Circle circle = new Circle(1, 3, 5);
            Elipse elipse = new Elipse(1, 1, 6, 3);
            circle.CircleDisplay();
            elipse.ElipseDisplay();
        }
    }
}