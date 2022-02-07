using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Kelvin, Fahrenheit;

            Console.WriteLine("Enter the temperature value on the Celsius scale");
            Celsius = double.Parse(Console.ReadLine());

            Fahrenheit = Celsius * 1.8;
            Kelvin = Celsius + 273.15;

            Console.WriteLine($"Result: {Celsius} degrees Celsius, {Kelvin} degrees Kelvin, { Fahrenheit} degrees Fahrenheit");
            Console.Read();
        }
    }
}
