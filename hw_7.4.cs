using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, y;
            Console.Write("enter x \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter y \t");
            y = int.Parse(Console.ReadLine());
            decimal d;
            d = y / 3;
            if (x > d)
            {
                Console.WriteLine("x more then y");
            }
            else if (x < d)
            {
                Console.WriteLine("x less than y");
            }
            else if (x == d)
            {
                Console.WriteLine("x equals y");
            }
            Console.Read();
        }
    }
}
