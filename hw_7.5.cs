using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("enter x km/h \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter y mp/s \t");
            y = int.Parse(Console.ReadLine());
            double d;
            d = x / 3.6;
            if (d > y)
            {
                Console.WriteLine("km/h more then mp/s");
            }
            else if (d < y)
            {
                Console.WriteLine("km/h less than mp/s");
            }
            else if (d == y)
            {
                Console.WriteLine("km/h equals mp/s");
            }
            Console.Read();
        }
    }
}
