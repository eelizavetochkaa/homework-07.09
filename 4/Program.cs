using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 4");
            Console.WriteLine("Программа считает косинус введённого значения (можно ввести в радианах и в градусах)");

            Console.WriteLine("Введите число x в радианах для нахождения его косинуса");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число a в градусах для нахождения его косинуса");

            double a = double.Parse(Console.ReadLine());

            double y = Math.Cos(x);

            double z = a / 180 * Math.PI;

            double n = Math.Cos(z);

            Console.WriteLine("Косинус числа х = " + y);

            Console.WriteLine("Косинус числа а = " + n);

            Console.ReadKey();
        }
    }
}
