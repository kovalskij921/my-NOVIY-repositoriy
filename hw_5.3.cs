using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number 1");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a number 2");
                int y = int.Parse(Console.ReadLine());

                if (x + y == 98)
                {
                    Console.WriteLine("True");
                }
                else if (x + y != 98)
                {
                    Console.WriteLine("False");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error, enter a number");
            }
            Console.Read();
        }
    }
    }

