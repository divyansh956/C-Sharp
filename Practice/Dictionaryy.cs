using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Dictionaryy
    {
        void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>() { { 3, "Ram" }, { 4, "KoKo" } };
            names.Add(1, "John");
            names.Add(2, "James");

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "Math", "A" },
                { "Science","B" }
            };
            teachers["English"] = "E";

            Console.WriteLine(teachers["Math"]);
            if (teachers.ContainsKey("English"))
            {
                teachers.Remove("English");
            }

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "M";
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }

        }
    }
}
