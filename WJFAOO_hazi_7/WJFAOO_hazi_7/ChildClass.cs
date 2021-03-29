using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersons
{
    class Child:Person
    {
        private string school;

        public Child(string name, int age,string school) : base(name, age)
        {
            this.school = school;
        }
        public override string ToString()
        {
            return base.ToString()+$"Iskola:{school}";
        }
        public string GetSchool()
        {
            return school;
        }
    }
}
