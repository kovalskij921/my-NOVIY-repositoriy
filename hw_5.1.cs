using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number 2");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("True");
            }
            else if (a < b)
            {
                Console.WriteLine("False");
            }
            else if (a == b)
            {
                Console.WriteLine("numder a = b");
            }
            Console.Read();
        }
    }
}
