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
            double y;
            int x;
            Console.Write("enter x");
            x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                y = Math.Sin(x);
            }
            else
            {
                y = Math.Cos(x);
            }
            Console.WriteLine(y);
            Console.Read();
        }
    }
}
