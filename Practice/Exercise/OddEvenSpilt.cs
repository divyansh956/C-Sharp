using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Exercise
{
    internal class OddEvenSpilt
    {
        void Main(string[] args)
        {
            List<int> odd = new List<int>(), even = new List<int>();
            Dictionary<int, List<int>> dp = new Dictionary<int, List<int>>();

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }

                if (dp.ContainsKey(i % 2))
                {
                    dp[i % 2].Add(i);
                }
                else
                {
                    dp.Add(i % 2, new List<int> { i });
                }
            }

            foreach (KeyValuePair<int, List<int>> item in dp)
            {
                string key = item.Key == 1 ? "Odd" : "Even";
                string values = string.Join(", ", item.Value);
                Console.WriteLine($"{key} - {values}");
            }
        }
    }
}
