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
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();

        }

    }


}