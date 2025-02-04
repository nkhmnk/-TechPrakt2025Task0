using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("Введіть перше число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;

                Console.WriteLine($"{num1} + {num2} = {sum}");
            }
        }
    }

}