using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Exercise
{
    internal class ReverseString
    {
        void Main(string[] args)
        {
            string message = "C# is a programming language";
            var reversedMessage = new string(message.Reverse().ToArray());
            Console.WriteLine(reversedMessage);

            // Another way to reverse a string
            char[] chars = message.ToCharArray();
            Array.Reverse(chars);
            reversedMessage = new string(chars);
            Console.WriteLine(reversedMessage);

            // Another way to reverse a string
            reversedMessage = string.Empty;
            for (int i = message.Length - 1; i >= 0; i--)
            {
                reversedMessage += message[i];
            }
            Console.WriteLine(reversedMessage);
        }
    }
}
