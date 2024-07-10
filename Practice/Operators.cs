using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Operators
    {
        void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            x--;
            x++;
            x = x + 1;
            x -= 1;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            x = 10;
            y = 5;
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);

            x = 10;
            y = 5;
            Console.WriteLine(x > 5 && y < 10);
            Console.WriteLine(x > 5 || y < 10);
            Console.WriteLine(!(x > 5 && y < 10));

            x = 10;
            y = 5;
            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);
            Console.WriteLine(~x);
            Console.WriteLine(x << 2);
            Console.WriteLine(x >> 2);

            string a = "Hello";
            string b = "World";
            a += b;
            Console.WriteLine(a);

            char c = 'A';
            c += 'b';
            Console.WriteLine(c);
        }
    }
}
