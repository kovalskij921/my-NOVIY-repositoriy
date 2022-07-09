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
            decimal x, y;
            Console.Write("enter x \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter y \t");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x - a larger number, y - smaller number");
            }
            else if (x < y)
            {
                Console.WriteLine("x - smaller number, y - a larger number");
            }
            else if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            Console.Read();
        }
    }
}
