using System;
using CHSARPCLASS.Classes;


namespace Testing
{
    class Program
    {
        static void Main()
        {
            var Kenny = new Human("Kenny", 20);
            Console.WriteLine(Kenny.Print());
            Kenny.Age = 20;
            Kenny.Name = "Kenny";
            Console.WriteLine(Kenny.Print());

            var Kid = new Teenager("Paul", 14, "School 14");
            Console.WriteLine(Kid.Print());
            Kid.Name = "Lisa";
            Kid.SetAge(10);
            Kid.School = "School 19";
            Console.WriteLine(Kid.Print());
        }
    }
}
