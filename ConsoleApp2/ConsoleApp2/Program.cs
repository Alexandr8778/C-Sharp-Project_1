using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            string[] s = Console.ReadLine().Split(' ');

            int a = Convert.ToInt16(s[0]);
            int b = Convert.ToInt16(s[1]);
            int c = Convert.ToInt16(s[2]);

            Console.WriteLine("MAX = " + Math.Max(a, Math.Max(c, b)));

            Console.ReadKey();
        }

    }
}
