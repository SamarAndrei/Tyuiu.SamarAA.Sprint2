using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SamarAA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Дата некоторого дня *");
            Console.WriteLine("* характеризуется тремя натуральными числами: g (год), m                  *");
            Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным g, n и m             *");
            Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год:");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер месяца:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (g <= 0 || m <= 0 || m > 12 || n <= 0 || n > 31)
            {
                Console.WriteLine("Введены некорректные данные!");
            }
            else
            {
                Console.WriteLine(ds.FindDateOfNextDay(g,m,n));
            }

            Console.ReadKey();
        }
    }
}
