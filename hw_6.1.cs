using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "The United Nations Convention on the Rights of the Child defines child as \" a human being below the age of 18 years unless under the law applicable to the child, majority is attained earlier\" ";
            a = a.Replace("child", "children");

            string str = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsDigit(a[i]))
                {
                    str += a[i];
                }
            }
            Console.WriteLine(str);


            Console.Read();
        }
    }
}
