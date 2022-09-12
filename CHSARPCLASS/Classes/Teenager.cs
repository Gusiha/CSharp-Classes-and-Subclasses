using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHSARPCLASS.Classes
{
    public class Teenager : Human
    {
        public string School { get; private set; }

        public Teenager(string name, int age, string schoolName) : base(name, age)
        {
            AgeRestrictor(age);
            School = schoolName;
        }
        public new void AgeSet(int age)
        {
            AgeRestrictor(age);
            Age = age;
        }

        private void AgeRestrictor(int age)
        {
            if (!(age >= 13) && !(age <= 19))
                throw new Exception("Invalid age!");
        }

        public void SchoolSet(string schoolName)
        {
            School = schoolName;
        }

        public new string Print()
        {
            return $"Teenager. Name: {Name}, Age: {Age}, School: {School}";
        }
    }
}
