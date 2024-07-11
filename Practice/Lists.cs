using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Lists
    {
        void Main(string[] args)
        {
            List<int> listNumbers = new List<int>() { 1, 2, 3 };
            listNumbers.Reverse();
            listNumbers.Add(4);
            listNumbers.Remove(4);
            listNumbers.RemoveAt(0);

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write(listNumbers[i] + " ");
            }
        }
    }
}
