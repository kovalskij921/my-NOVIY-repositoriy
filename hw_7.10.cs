using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, year, month, date, age;
            Console.Write("year");
            a = int.Parse(Console.ReadLine());
            Console.Write("month");
            b = int.Parse(Console.ReadLine());
            Console.Write("date");
            c = int.Parse(Console.ReadLine());

            date = 20;
            if (c > date)
            {
                b++;
            }
            month = 8;
            if (b > month)
            {
                a++;
            }
            year = 2022;
            age = year - a;
            Console.WriteLine(age);
            Console.Read();



        }
    }
}
