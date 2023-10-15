using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamarAA.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1:
                case 2:
                case 12: return "Зима";
                case 3:
                case 4:
                case 5: return "Весна";
                case 6:
                case 7:
                case 8: return "Лето";
                case 9:
                case 10:
                case 11: return "Осень";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");

            }
        }
    }
}
