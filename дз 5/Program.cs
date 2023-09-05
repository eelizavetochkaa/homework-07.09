using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 6");
            Console.WriteLine("Программа обмена значениями трёх переменных величин a, b, c");
            Console.WriteLine("Введите число a ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("а." + b + " " + c + " " + a);
            Console.WriteLine("b." + c + " " + a + " " + b);

            Console.ReadKey();
        }
    }
}
