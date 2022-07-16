using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("enter circle radius \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter y square radius \t");
            y = int.Parse(Console.ReadLine());
            double d;
            d = y / 4;
            if (d > y)
            {
                Console.WriteLine("circle radius more then square radius");
            }
            else if (x < d)
            {
                Console.WriteLine("circle radius less than square radius");
            }
            else if (x == d)
            {
                Console.WriteLine("circle radius equals square radius");
            }
            Console.Read();
        }
    }
}
