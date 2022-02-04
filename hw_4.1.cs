using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, Result, square;  // I used "bukavi" because it's more convenient that way
            Console.WriteLine("Enter a number 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number 3");
            c = double.Parse(Console.ReadLine());
            square = (Math.Pow((c + (a * b) / c), 2));
            Result = a + b - c * ((3 * a * b) + (Math.Pow(a, 2)) / (b * c)) - (c + (a * b) / c) * square;
            Math.Round(Result, 2);
            Console.WriteLine($"Answer {Math.Round(Result, 2)}");
            Console.Read();
        }
    }
}
