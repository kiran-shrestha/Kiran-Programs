using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Random rand = new Random();
            int number = rand.Next(10);
            do
            {
                Console.Write("Try and guess my number: ");
                counter++;
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    break;
                }
                else
                {
                    Console.Write("Hard Luck, press ENTER to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (true);

            Console.WriteLine($"You took {counter} guesses to my number...");

        }
    }
}
