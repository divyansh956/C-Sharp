using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    internal class Strings
    {
        void Main(string[] args)
        {
            string path = "C:\\Users\\Desktop\\C#";
            path = @"C:\Users\Desktop\C#"; // Verbatim string literal
            string speech = "Hello, my name is \"John\".";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            string s = @"Hello ""John""";
            s = @"Hello 'John'";
            Console.WriteLine(s);

            string name = "John";
            int age = 30;
            string message = string.Format("My name is {0} and I am {1} years old.", name, age);
            Console.WriteLine(message);

            string test = string.Concat("Hello", " ", "World");
            Console.WriteLine(test);

            Console.WriteLine("My name is {0} and I am {1} years old.", name, age); // Composite formatting
            Console.WriteLine($"My name is {name} and I am {age} years old."); // String interpolation

            Console.WriteLine("" == string.Empty || string.IsNullOrEmpty("")); // True
            Console.WriteLine("Hello".Equals("Hello"));

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object s1 = new string(chars);
            Console.WriteLine("Hello" == s1); // False (Reference equality)

            message = "C# is a programming language";
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();

            Console.WriteLine(message.Substring(4, 3));
            Console.WriteLine(message.IndexOf("programming"));
            Console.WriteLine("Message".Contains("e"));
            string[] words = message.Split(' ');
            foreach (var word in words)
            {
                Console.Write(word);
            }
        }
    }
}
