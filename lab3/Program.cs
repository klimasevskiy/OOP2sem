using System;

namespace lab3
{
    class Program
    {
        public struct Student
        {
            public string prizv;
            public int kurs;
            public string spec;
            public int fiz;
            public int mat;
            public int prog;
        };

        static void Main(string[] args)
        {
            string str = "Drogobych, (city), house, university";
            char[] modifiedstr = str.ToCharArray();
            Console.WriteLine($"STRING = {str}");

            #region task1
            /*Дано літерний рядок, який містить послідовність символів s0, ..., sn, ... .Відомо, що
            серед цих символів є по крайній мірі три коми.
            1. Знайти число і таке, що sі – третя за порядком кома.
            2. Замінити кожну кому парою зірочок “**”.*/
            Console.WriteLine();
            Console.WriteLine("TASK 1:");
            int k = 0;
            int nomer = 0;
            if (str.Length < 3)
                k = 0;
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ',' && k < 3)
                    {
                        k++;
                        nomer = i + 1;
                    }
                    else if (k == 3)
                        break;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ',')
                    {
                        modifiedstr[i] = '*';
                    }
                }
            }
            if (k > 0)
                Console.WriteLine($"third , number: {nomer}");
            else
                Console.WriteLine("there are less than 3 elements, or no ',' symbols");

            Console.WriteLine($"Modified String = {String.Join("", modifiedstr)}");
            modifiedstr = str.ToCharArray();
            #endregion

            #region task2
            /*Дано літерний рядок, який містить послідовність символів s0, ..., sn, ... . Вилучити з
            цієї послідовності групи символів, які знаходяться між дужками «(», «)».Самі дужки теж
            мають бути вилучені.Вважається, що всередині кожної пари дужок нема інших дужок.Якщо
            всередині деякої пари дужок є пара інших дужок(вкладені дужки), то виводиться
            повідомлення про помилку.*/
            Console.WriteLine();
            Console.WriteLine("TASK 2:");

            int k1 = 0;
            int k2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' && k != 2)
                {
                    k1++;
                }

                else if (k == 2)
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == ')' && k != 2)
                        {
                            k2++;
                        }
                    }
            }
            if (k1 != 1 && k2 != 1)
                Console.WriteLine("ERROR \n STRING CONTAINES MORE THAN 1 BRACKETS");
            else
            {
                int pos = str.IndexOf("(");
                int pos2 = str.IndexOf(")");
                modifiedstr = str.Remove(pos, pos2 - pos + 1).ToCharArray();
                Console.WriteLine($"Modified String = {String.Join("", modifiedstr)}");
                modifiedstr = str.ToCharArray();
            }

            #endregion

            #region task3
            /*1. Вивести прізвища студентів, які вчаться без трійок (на “відмінно” і “добре”).
              2. Обчислити кількість студентів, які отримали з фізики оцінку “5”.*/
            string[] lastnames = { "Klimasevskiy", "Halamay", "Bilionok", "Yachechak", "Savshak", "Illnytskiy", "Senyshyn" };
            string[] specialnist = { "комп науки", "мат i економ", "iнформ", "фiз i iнформ", "труд навч" };

            Console.WriteLine();
            Console.WriteLine("Завдання 2:");

            Console.Write("Кiлькiсть студентiв = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] p = new Student[N]; // створення посилання на об`єкт типу Student
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                p[i].prizv = lastnames[rand.Next(7)];
                p[i].kurs = rand.Next(1, 5);
                p[i].spec = specialnist[rand.Next(5)];
                p[i].fiz = rand.Next(2, 6);
                p[i].mat = rand.Next(2, 6);
                p[i].prog = rand.Next(2, 6);
            }
            Console.WriteLine("===============================================================================\n" +
                              "| № |  Прiзвище  | Курс | Cпецiальнiсть | Фiзика | Математика | Програмування |\n" +
                              "-------------------------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"|{i,3}|{p[i].prizv,12}|{p[i].kurs,6}|{p[i].spec,15}|{p[i].fiz,8}|{p[i].mat,12}|{p[i].prog,15}|");
            }
            Console.WriteLine("===============================================================================");

            Console.WriteLine("Студенти що мають 5 з фiзики\n" +
                          "| № |  Прiзвище  |");
            for (int i = 0; i < N; i++)
            {
                if (p[i].fiz == 5)
                {
                    Console.WriteLine($"|{i,3}|{p[i].prizv,12}|");
                }
            }

            #endregion
        }
    }
}
