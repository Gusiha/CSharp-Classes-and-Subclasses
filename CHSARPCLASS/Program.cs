using System;
using CHSARPCLASS.Classes;


namespace Testing
{
    class Program
    {
        public static int Score { get; set; } = 0;

        static void Main()
        {
            var Pool = BowlingObjectPool.GetInstance();

            var ball = Pool.GetObject();

            Score += ball.Throw();

            Console.WriteLine(Score);
        }
    }
}
