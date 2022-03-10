using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_the_main_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a sequence of characters\t");
            string symbols = (Console.ReadLine());
            int counter1 = 1;
            int counter2 = 0;
            for (int i = 0; i < symbols.Length - 1; i++)
            {

                if (symbols[i] != symbols[i + 1])
                {
                    counter1++;
                    if (counter1 > counter2)
                    {
                        counter2 = counter1;
                    }
                }
                else if (symbols[i] == symbols[i + 1])
                {
                    counter1 = 1;
                }
            }
            Console.WriteLine(counter2);
            Console.Read();
        }
    }
    }

