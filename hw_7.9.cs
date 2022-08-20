using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D;
            Console.Write("enter the number one \t");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter the number two \t");
            b = int.Parse(Console.ReadLine());
            Console.Write("enter the number three \t");
            c = int.Parse(Console.ReadLine());
            D = (b * b) - ((4 * a) * c);
            if (D > 0)
            {
                Console.WriteLine("the equation has real roots");
            }
            else
            {
                Console.WriteLine("the equation does not have real roots");
            }
            
            Console.Read();
        }
    }
}
