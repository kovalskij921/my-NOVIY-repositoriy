using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number a");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a number y");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a number z");
                int z = int.Parse(Console.ReadLine());


                if (x + y == z)
                {
                    Console.WriteLine("The sum of the numbers a and b is equal to z");
                }
                else if (x + y != z)
                {
                    Console.WriteLine("Еhe sum of the numbers a and b is not equal to z");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error, enter a number");
            }
            Console.Read();
        }
    }
}
