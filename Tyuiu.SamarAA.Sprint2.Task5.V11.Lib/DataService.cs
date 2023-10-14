using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamarAA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextG, nextM, nextN;

            switch (m)
            {
                case 2:
                    if (n < 28)
                    {
                        nextG = g;
                        nextM = m;
                        nextN = n + 1;
                    }
                    else if (n == 28)
                    {
                        nextG = g;
                        nextM = m + 1;
                        nextN = 1;
                    }
                    else
                    {
                        nextG = 0;
                        nextM = 0;
                        nextN = 0;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        nextG = g;
                        nextM = m;
                        nextN = n + 1;
                    }
                    else if (n == 30)
                    {
                        nextG = g;
                        nextM = m + 1;
                        nextN = 1;
                    }
                    else
                    {
                        nextG = 0;
                        nextM = 0;
                        nextN = 0;
                    }
                    break;

                default:
                    if (n < 31)
                    {
                        nextG = g;
                        nextM = m;
                        nextN = n + 1;
                    }
                    else if (n == 31)
                    {
                        nextG = g;
                        if (m == 12)
                        {
                            nextM = 1;
                            nextG = g + 1;
                        }
                        else
                        {
                            nextM = m + 1;
                        }
                        nextN = 1;
                    }
                    else
                    {
                        nextG = 0;
                        nextM = 0;
                        nextN = 0;
                    }
                    break;
            }
            string res = Convert.ToString(($"Следующий день: {nextN}.{nextM}.{nextG}"));
            return res;
        }

    }
}
