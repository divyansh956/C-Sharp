using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Test
    {
        public static void TestFunction()
        {
            Console.WriteLine("Test Function");
        }
    }
    internal class Functions
    {
        void Main()
        {
            PrintHelloWorld();
            Test.TestFunction();

            bool success = int.TryParse("123", out int result); // TryParse returns true if the parsing was successful
            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }

            int sum = Add(5, 10);
            Console.WriteLine(sum);

            string nameInput = "John";
            int ageInput = 25;
            PrintNameAndAge(age: ageInput, name: nameInput); // Named arguments

            bool changed = changeNumber(out int num); // out argument
            Console.WriteLine(num);

            int n = 19;
            changeNum(ref n); // reference argument
            Console.WriteLine(n);
        }

        static void changeNum(ref int num)
        {
            num = 10;
        }

        static bool changeNumber(out int num)
        {
            num = 5;
            return true;
        }

        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static int Add(int a, [Optional] int b)
        {
            return a + b;
        }
    }

}