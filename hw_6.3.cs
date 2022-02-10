using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Godelteamwithsomeofexcersicesabcwanttomakeitbetter";

            int ind = text.Length - 21;
            string a;
            a = text.Remove(ind);
            Console.WriteLine(a);

            string b;
            b = text.Remove(0, 32);
            Console.WriteLine(b);
            // я еле додумался до этого, только к вечеру начал эксперементировать, помогите...
            Console.Read();
        }
    }
}
