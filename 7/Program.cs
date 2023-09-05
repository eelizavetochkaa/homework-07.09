using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double random1 = random.Next();
            double random2 = random.Next();
            double random3 = random.Next();
            double random4 = random.Next();

            Console.WriteLine("Номер 7");
            Console.WriteLine("Внизу стобликом выведены 4 рандомных числа");

            Console.WriteLine(random1);
            Console.WriteLine(random2);
            Console.WriteLine(random3);
            Console.WriteLine(random4);
            Console.ReadKey();
        }
    }
}
