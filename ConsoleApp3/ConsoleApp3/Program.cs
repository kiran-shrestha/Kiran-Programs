using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 2*/
            int total = 0;
            for (int i = 0; i < 10; i++) ;
            {
                Console.WriteLine("please enter a number");
                total = total + int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Total: {total}");

            bool loop = true;
            do
            {
                Console.Write("please enter a number: ");
                total = total + int.Parse(Console.ReadLine());

                Console.WriteLine("would you like to add another number(y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                    loop = false;
            }while (loop == true);
                Console.WriteLine($"Total: {total}");

               
            }


        }
    }
