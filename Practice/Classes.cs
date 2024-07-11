using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Classes
    {
        class Person
        {
            private string name;
            public int Age { get; set; } // Auto-implemented property

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Person()
            {
                Name = "Unknown";
                Age = 0;
            }

            public Person(string name)
            {
                Name = name;
                Age = 0;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void setName(string name) => this.name = name;

            public string getName() => name;

            public string returnDetails()
            {
                return "Name: " + Name + ", Age: " + Age;
            }

            public override string ToString() // Overriding ToString method
            {
                return returnDetails();
            }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return Name.Equals(person.Name) && Age.Equals(person.Age);
                }
                return false;
            }

            public static bool operator ==(Person person1, Person person2)
            {
                if (ReferenceEquals(person1, person2))
                {
                    return true;
                }
                if (person1 is null || person2 is null)
                {
                    return false;
                }
                return person1.Name == person2.Name && person1.Age == person2.Age;
            }

            public static bool operator !=(Person person1, Person person2)
            {
                return !(person1 == person2);
            }
        }

        void Main(string[] args)
        {
            Person person = new Person("John", 25);
            // Console.WriteLine("Name: " + person.name + ", Age: " + person.age);
            Console.WriteLine(person.returnDetails());
            person.setName("Jane");
            Console.WriteLine(person.getName());

            person.Name = "Doe";
            person.Age = 30;
            Console.WriteLine(person.returnDetails());
            Console.WriteLine(person);

            Person test1 = new Person("John", 25);
            Person test2 = new Person("John", 25);
            Console.WriteLine(test1.Equals(test2));
            Console.WriteLine(test1 == test2);
        }
    }
}
