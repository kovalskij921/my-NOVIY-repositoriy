using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {number}");
            Console.Read();
        }
    }
}
