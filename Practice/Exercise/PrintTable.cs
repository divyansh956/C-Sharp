using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Exercise
{
    internal class PrintTable
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    success = false;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} * {i} = {num * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
