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
            Console.WriteLine("Напишите трехзначное число: ");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            if (n == 6 || n == 7)
            {
                Console.WriteLine("Да, это выходной.");
            }
            else if (n > 6)
            {
                Console.WriteLine("Такого дня в недели не существует!");
            }
            else Console.WriteLine("Нет, это будний день!");

            Console.ReadKey();

        }

    }


}