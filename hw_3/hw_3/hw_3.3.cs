using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите свой возрас: ");
            int age, age2;
            age = int.Parse(Console.ReadLine());
            age2 = 2022 - age;
            Console.WriteLine(age2);

            Console.WriteLine("Введите свой род деятельности: ");
            string activity = Console.ReadLine();

            Console.WriteLine("Вы женаты? (введите <да> или <нет>): ");
            string status = "да";
            if (status == Console.ReadLine())
            {
                Console.WriteLine($" Женат");
            }
            else if (status != Console.ReadLine())
            {
                Console.WriteLine($"Не женат");
            }

            Console.WriteLine("Введите актуальный курс валют");
            decimal a;
            a = decimal.Parse(Console.ReadLine());








            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Родился в: {age2}");
            Console.WriteLine($"Род деятельности: {activity}");
            Console.WriteLine($"Семейное положение: {status}");
            Console.WriteLine($"Курс валют на сегодня: {a}");
            Console.Read();
            
        }
    }
}
