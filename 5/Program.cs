using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 5");
            Console.WriteLine("Программа находит корни уравнения исходя их введённых коэффициентов");

            Console.WriteLine("Введите старший коэффициент а = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c = ");
            int c = int.Parse(Console.ReadLine());


            double D = Math.Sqrt(b * b - 4 * a * c);

            double x1 = (-b + D) / (2 * a);
            double x2 = (-b - D) / (2 * a);

            if (x1 == x2)
            {
                Console.WriteLine("Корень уравнения один = " + x1);

            }
            else
            {
                Console.WriteLine("Первый корень уравнения = " + x1);

                Console.WriteLine("Второй корень уравнения = " + x2);
            }

            Console.ReadKey();
        }
    }
}
