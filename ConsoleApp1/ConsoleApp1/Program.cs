﻿using System;
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
            Console.WriteLine("Введите 1 число:");
            string s = Console.ReadLine();
            int a = Convert.ToInt16(s);
            Console.WriteLine("Введите 2 число:");
            s = Console.ReadLine();
            int b = Convert.ToInt16(s);

            Console.WriteLine("MAX = ");
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else Console.WriteLine(b);

            Console.ReadKey();
        }

    }
}
