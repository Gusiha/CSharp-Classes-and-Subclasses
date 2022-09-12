﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHSARPCLASS.Classes
{
    public class Worker : Human
    {
        public string Workplace { get; private set; }
        public int YoS { get; private set; }

        public void YoSSet(int years)
        { YoS = years; }

        private void AgeRestrictor(int age)
        {
            if (!(age >= 16) && !(age <= 34))
                throw new Exception("Invlalid age!");
        }

        public Worker(string name, int age, string workplace) : base(name, age)
        {
            Age = age;
            Workplace = workplace;
        }
    }
}
