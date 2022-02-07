using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write something");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);

            if (str.Length > 13)
            {
                Console.WriteLine("the number of characters is more than 13");
            }
            else if (str.Length < 13)
            {
                Console.WriteLine("the number of characters is less than 13");
            }
            else if (str.Length == 13)
            {
                Console.WriteLine("the number of characters is 13");
            }
            Console.Read();
        }
    }
}
