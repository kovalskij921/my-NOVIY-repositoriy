using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int dec = 0;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++, j--)
            {
                if (hex[i] == 'A') { dec += 10 * (int)Math.Pow(16, j); }
                else if (hex[i] == 'B')
                    dec += 11 * (int)Math.Pow(16, j);
                else if (hex[i] == 'C')
                    dec += 12 * (int)Math.Pow(16, j);
                else if (hex[i] == 'D')
                    dec += 13 * (int)Math.Pow(16, j);
                else if (hex[i] == 'E')
                    dec += 14 * (int)Math.Pow(16, j);
                else if (hex[i] == 'F')
                    dec += 15 * (int)Math.Pow(16, j);
                else
                    dec += hex[i] - '0' * (int)Math.Pow(16, j);
            }
            Console.WriteLine(dec);
            Console.ReadLine();
        }
    }
}
