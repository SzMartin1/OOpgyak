using System;
using MyPersons;

namespace MyPersonsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = ReadPerson();
            Person person2 = ReadPerson();

            if (person1 is Adult)
            {
                Console.WriteLine("'person1' egy felnőtt!");
            }
            else
            {
                Console.WriteLine("'person1' egy gyermek!");
            }

            if (person2 is Child)
            {
                Console.WriteLine("'person2' egy gyermek!");
            }
            else
            {
                Console.WriteLine("'person2' egy felnőtt!");
            }

            int quantity = ReadIntInCheckedMode();
            Person[] people = new Person[quantity];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = ReadPerson();
            }
            PrintArrayInSortedMode(people);
        }

        static Person ReadPerson()
        {
            Person person;
            Console.WriteLine("Személy neve:");
            string name = Console.ReadLine();

            Console.WriteLine("Személy életkora:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age<18)
            {
                Console.WriteLine("Gyermek iskolája:");
                string school = Console.ReadLine();
                person = new Child(name, age, school);
            }
            else
            {
                Console.WriteLine("Felnőtt munkahelye:");
                string workplace = Console.ReadLine();
                if (string.IsNullOrEmpty(workplace))
                {
                    person = new Adult(name, age, workplace);
                }
                else
                {
                    int salary = Convert.ToInt32(Console.ReadLine());
                    person = new Employee(name, age, workplace, salary);
                }
            }
            return person;
        }
        static int ReadIntInCheckedMode()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine("Hibás az input, számot adjon meg!");
            }
            return number;
        }

        static void PrintArrayInSortedMode(Person[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].Age<array[min].Age)
                    {
                        min = j;
                    }
                }
                if (min!=i)
                {
                    Person temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
                for (int k = 0; k < array.Length; k++)
                {
                    Console.WriteLine(array[k]);
                }
            }
        }
    }
}
