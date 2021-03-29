using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersons

{
    class Person
    {
        private string name;
        private int age;

        public string Name { get => name;}
        public int Age { get => age;}

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Név:{name}, Életkor:{age}";
        }

        public bool ReturnTrueIfAgeIsHigher(Person person)
        {
            if (person.age>this.age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
