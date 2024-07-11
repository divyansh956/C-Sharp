using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Exercise
{
    internal class SumOfArray
    {
        void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int sum = SumOfNumbers(numbers);
            Console.WriteLine(sum);
        }

        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
