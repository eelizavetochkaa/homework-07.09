using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 3");
            Console.WriteLine("Программа считает длину и площадь окружности исходя из заданного радиуса");
            Console.WriteLine("Введите радиус окружности");

            double R = double.Parse(Console.ReadLine());

            double L = 2 * Math.PI * R;
            double S = Math.PI * R * R;
            Console.WriteLine("Длина окружности = " + L);
            Console.WriteLine("Площадь круга = " + S);
            Console.ReadKey();
        }
    }
}
