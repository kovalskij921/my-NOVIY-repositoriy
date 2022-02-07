using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3
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
            int age, b;
            age = int.Parse(Console.ReadLine());
            age2 = 2022 - age;
            Console.WriteLine(age2);

            Console.WriteLine("Введите свой род деятельности: ");
            string activity = Console.ReadLine();

            Console.WriteLine("Вы женаты? (введите <да> или <нет>: ");
            string name = "да";
            if (name == Console.ReadLine())
            {
                Console.WriteLine($" true");
            }
            else if (name != Console.ReadLine())
            {
                Console.WriteLine($"false");
            }






            Console.WriteLine($"женат: {name}");
            Console.WriteLine($"Имя: {surname}");
            Console.WriteLine($"Возраст: {age2}");
            Console.WriteLine($"Вес: {activity}");
            Console.WriteLine($"Работает: {name}");
            Console.Read();




        }
    }
}
