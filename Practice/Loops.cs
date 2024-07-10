using System;

namespace Practice
{
    internal class Loops
    {
        void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);

            var name = "John Smith";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
