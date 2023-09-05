using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашнее_задание_07._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string peace = "Мир ";
            string lanbour = "Труд ";
            string May = "Май";
            Console.WriteLine("Номер 1");
            Console.WriteLine("Программа выводит фразу вначале в строчку, затем в столбик");
            Console.WriteLine(peace + lanbour + May);
            Console.ReadKey();
            Console.WriteLine(peace);
            Console.WriteLine("   " + lanbour);
            Console.WriteLine("      " + May);
            Console.ReadKey();
        }
    }
}
