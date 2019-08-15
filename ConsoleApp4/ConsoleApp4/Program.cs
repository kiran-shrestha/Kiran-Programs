using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(i%2!=0)
                    Console.Write($"{i}\t");
                else
                    Console.Write($"{i}\n");
            }
        }
    }
}
