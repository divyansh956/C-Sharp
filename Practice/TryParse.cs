using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TryParse
    {
        void Main(string[] args)
        {
            string numInput = Console.ReadLine();

            bool success = int.TryParse(numInput, out int num);
            if (!success)
            {
                Console.WriteLine("Invalid number");
                return;
            }

            Console.WriteLine(num);
        }
    }
}
