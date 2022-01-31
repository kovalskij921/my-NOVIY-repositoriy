using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int numberOne;
            numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int numberTwo;
            numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int numberThree;
            numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int numberFour;
            numberFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne} {numberTwo} {numberThree} {numberFour}");
            Console.Read();

        }
    }
}
