using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHSARPCLASS.Classes
{
    public class Teenager : Human
    {
        private string _school;
        public string School {
            get
            {
                return _school;
            }
            set
            {
                _school = value;
            }
        }

        public new int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                AgeRestrictor(value);
                _age = value;
            }
        }

        public Teenager(string name, int age, string schoolName) : base(name, age)
        {
            AgeRestrictor(age);
            School = schoolName;
        }

        public void SetAge (int age)
        {
            AgeRestrictor(age);
            _age = age;
        }

        private void AgeRestrictor(int age)
        {
            if (!((age >= 13) && (age <= 19)))
                throw new Exception("Invalid age!");
        }

        /*public void SchoolSet(string schoolName)
        {
            School = schoolName;
        }*/

        public new string Print()
        {
            return $"Teenager. Name: {Name}, Age: {Age}, School: {School}";
        }
    }
}
