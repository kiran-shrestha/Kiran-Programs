using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 1;
            int temp;

            Console.Write("How many fibonachi numbers would you like to see: ");
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1}\n{num2}");
            for(int i = 2; i < counter; i++)
            {
                temp = num1 + num2;
                Console.WriteLine(temp);
                num1 = num2;
                num2 = temp;
            }
        }
    }
}
