using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите число 1");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            b = double.Parse(Console.ReadLine());

            double c = a + b;

            double result = Math.Sqrt(a * b);
            Console.WriteLine($"Результат: {result} {c}");
            Console.Read();
        }
    }
}
