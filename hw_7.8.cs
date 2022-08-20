using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, y, y1;
            Console.Write("specify the resistance of the first section \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("specify the voltage of the first section \t");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("specify the resistance of the second section \t");
            y = int.Parse(Console.ReadLine());
            Console.Write("specify the voltage of the second section \t");
            y1 = int.Parse(Console.ReadLine());
            double d, v;
            d = x - x1;
            v = y - y1;
            if (d > v)
            {
                Console.WriteLine("a larger current flows through the second section");
            }
            else if (d < v)
            {
                Console.WriteLine("a larger current flows through the first section");
            }
            else if (d == v)
            {
                Console.WriteLine("both sections have the same voltage");
            }
            Console.Read();
        }
    }
}
