using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersons
{
    class Employee : Adult
    {
        private long salary;
        private static int retirementAge=65;
        public Employee(string name, int age, string workplace,long salary) : base(name, age, workplace)
        {
            this.salary = salary;
        }

        public long GetSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            return base.ToString()+$"Fizetés:{salary}";
        }
    }
}
