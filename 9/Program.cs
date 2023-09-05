using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 9");
            Console.WriteLine("Программа считает сумму покупок при заданных стоимости и весе");

            Console.WriteLine("Введите стоимость 1 кг кофет");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг печенья");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг яблок");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите, сколько кг кофет купили");
            double a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите, сколько кг печенья купили");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите, сколько кг яблок купили");
            double c1 = double.Parse(Console.ReadLine());

            double summ = a1 * a + b1 * b + c1 * c;

            Console.WriteLine("Сумма всей покупки = " + summ);

            Console.ReadKey();
        }
    }
}
