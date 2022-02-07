using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 100);

            int a, b;
            Console.WriteLine("enter a number a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number b");
            b = int.Parse(Console.ReadLine());

            if (a > value)
            {
                Console.WriteLine("True");
            }
            else if (b > value)
            {
                Console.WriteLine("True");
            }
            else if (a < value)
            {
                Console.WriteLine("False");
            }
            else if (b < value)
            {
                Console.WriteLine("False");
            }

            Console.Read();
        }
    }
}
