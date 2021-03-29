using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersons
{
    class Adult : Person
    {
        private string workplace;
        public Adult(string name, int age,string workplace) : base(name, age)
        {
            this.workplace = workplace;
        }
        public string GetWorkplace()
        {
            return workplace;
        }
        public override string ToString()
        {
            return base.ToString()+$"Munkahely:{workplace}";
        }
    }
}
