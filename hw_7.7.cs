using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,x1,y,y1;
            Console.Write("enter the volume of the first body \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter the mass of the first body \t");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("enter the volume of the second body \t");
            y = int.Parse(Console.ReadLine());
            Console.Write("enter the mass of the second bod \t");
            y1 = int.Parse(Console.ReadLine());
            double d, v;
            d = x / x1;
            v = y / y1;
            if (d > v)
            {
                Console.WriteLine("body one more then body two");
            }
            else if (d < v)
            {
                Console.WriteLine("body one less than body two");
            }
            else if (d == v)
            {
                Console.WriteLine("body one equals body two");
            }
            Console.Read();
        }
    }
}
