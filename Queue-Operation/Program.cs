using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("                   My Training Schedule");
                Console.WriteLine("=============================================================");
                Console.WriteLine("1. Add Exercise");
                Console.WriteLine("2. Remove Exercise");
                Console.WriteLine("3. Show Total Number of Exercises");
                Console.WriteLine("4. Show the shortest and longest training day");
                Console.WriteLine("5. Find exercise");
                Console.WriteLine("6. Show all exercises");
                Console.WriteLine("7. Show all exercises for specific day");
                Console.WriteLine("8. Exit rogram");

                int userChoice= Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Illegal Input");
                        break;

                }
            }
        }
    }
}
