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
            if (n % 2 == 0)
            {
                Console.WriteLine("Число является четным");
            }
            else Console.WriteLine("Число является не четным");
            
            Console.ReadKey();

        }

    }


}