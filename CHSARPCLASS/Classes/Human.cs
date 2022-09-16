using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHSARPCLASS.Classes
{
    public class Human
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Restrictor(value);
                _name = value;
            }
        }

        protected int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
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
