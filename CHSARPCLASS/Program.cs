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
            Kenny.AgeSet(20);
            Kenny.NameSet("Kenny");
            Console.WriteLine(Kenny.Print());

            var Kid = new Teenager("Paul", 14, "School 14");
            Console.WriteLine(Kid.Print());
            Kid.NameSet("Lisa");
            Kid.AgeSet(13);
            Kid.SchoolSet("School 15");
            Console.WriteLine(Kid.Print());
        }
    }
}