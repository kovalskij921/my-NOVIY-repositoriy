using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Bad day";
            string b = "Good";
            string c = "!!!!!!!!!";
            string d = "?";

            text = text.Substring(3);
            text = text.Insert(0, b);
            text = text.Insert(8, c);

            int ind = text.Length - 1;

            text = text.Remove(ind);

            text = text.Insert(16, d);

            Console.WriteLine(text);
            Console.Read();
        }
    }
}
