using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 2");
            Console.WriteLine("Программа меняет местами 2 введённых числа");

            Console.WriteLine("Введите 1е число");

            string a = Console.ReadLine();

            Console.WriteLine("Введите 2е число");

            string b = Console.ReadLine();

            Console.WriteLine(b + " " + a);

            Console.ReadKey();
        }
    }
}
