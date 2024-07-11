using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Arrays
    {
        void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var nums = new int[4];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            nums[0] = default; // Set to default value

            Array.Sort(nums);
            Array.Reverse(nums);
            Array.IndexOf(nums, 10); // Returns the index of the element
            Array.IndexOf(nums, 10, 2); // Returns the index of the element starting from index i
            Array.IndexOf(nums, 10, 0, 2); // Returns the index of the element starting from index i to i + size
            Array.Exists(nums, n => n == 10); // Returns true if the element exists
            Array.LastIndexOf(nums, 10); // Returns the last index of the element
            Array.Resize(ref nums, 10); // Resize the array
            Array.Clear(nums, 0, nums.Length); // Clear the array but keep the size
            Array.Clear(nums, 1, 2); // Clear the array from index i to i + size

        }
    }
}
