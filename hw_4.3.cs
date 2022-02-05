using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("number");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine(n.ToString().Reverse().ToArray());
            Console.Read();
        }
    }
}
