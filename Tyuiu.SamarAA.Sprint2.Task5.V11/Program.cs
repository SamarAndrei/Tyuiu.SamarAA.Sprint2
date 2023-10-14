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
            int g = 1;
            int m = 2;
            int n = 3;
            string wait = "4";
            string res = Convert.ToString(g + m + n);
            Console.WriteLine(wait + res);
            Console.ReadKey();
        }
    }
}
