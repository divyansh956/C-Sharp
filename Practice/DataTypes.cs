using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DataTypes
    {
        void Main(string[] args)
        {
            string textAge = "20";
            int age = 25; // Default type for whole numbers is int
            age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNum = 1000000L;
            Console.WriteLine(bigNum);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -56.2D; // Default type for decimal numbers is double
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float smallNum = 3.14F; // F is required for float
            Console.WriteLine(smallNum);

            decimal balance = 100.5M; // M is required for decimal
            Console.WriteLine(balance);

            string name = "John Doe";
            char character = 'A';
            bool isTrue = true;
            Console.WriteLine("My name is " + name);
            Console.WriteLine(character);
            Console.WriteLine(isTrue);

            var myVar = 10; // Compiler will determine the type
            Console.WriteLine(myVar);

            const double PI = 3.14159; // Constant value
            Console.WriteLine(PI);
        }
    }
}
