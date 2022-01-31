using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numberOne;
            numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int numberTwo;
            numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int numberThree;
            numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine($"Result - {numberOne}, Result - {numberTwo}, Result - {numberThree}");
            Console.Read();
        }
    }
}
