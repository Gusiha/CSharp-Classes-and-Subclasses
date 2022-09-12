using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHSARPCLASS.Classes
{
    public class Human
    {
        public string Name
        {
            get
            {
                return Name;
            }
            protected set
            {
                Restrictor(value);
                Name = value;
            }
        }

        public void NameSet(string name)
        {
            Restrictor(name);
            Name = name;
        }
        public int Age { get; protected set; }
        public void AgeSet(int age)
        {
            Age = age;
        }

        public Human(string name, int age)
        {
            Restrictor(name);
            Name = name;
            Age = age;
        }

        protected void Restrictor(string name)
        {
            if (name is null)
                throw new Exception("Name cannot be empty!");
        }

        public string Print()
        {
            return $"Human. Name: {Name}, Age: {Age}";
        }
    }

}
