using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b, c;
            Console.WriteLine("Стоимость плитки шоколада");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Стоимость кофе");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.WriteLine("Стоимость пакета молока");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            int result = a + b + c;
            Console.WriteLine("Общая стоимость продуктов = " + result);
            Console.Read();
        }
    }
}
