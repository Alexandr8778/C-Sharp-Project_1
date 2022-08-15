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
              if (s.Length > 2)
              {
                  Console.WriteLine("Третьим числом является: " + s[2]);
              }
              else Console.Write(s + " - Третьей цифры нет");

            Console.ReadKey();
        }

    }


}