using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Structure
    {
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        void Main(string[] args)
        {
            Person person1 = new Person("Ram", 25);
            Person person2 = CreatePerson();
            Console.WriteLine($"{person1.name} - {person1.age}");
            Console.WriteLine($"{person2.name} - {person2.age}");
        }

        static Person CreatePerson()
        {
            Console.Write("Enter name and age: ");
            return new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
    }
}
