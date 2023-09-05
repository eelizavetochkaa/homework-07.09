using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 8");
            Console.WriteLine("Программа выдаёт число, полученное при зачёркивании последней цифры трёхзначного числа и приписывании этой цифры в начало)");
            Console.WriteLine("Введите трёхзначное число");

            int a = int.Parse(Console.ReadLine());

            int b = a % 10;

            int c = a / 10;

            if (b == 0)
            {
                Console.WriteLine(c);
            }
            else
            {
                string str1 = b.ToString();
                string str2 = c.ToString();
                Console.WriteLine(str1 + str2);
            }
            Console.ReadKey();
        }
    }
}
