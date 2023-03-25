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

            BowlingBall[] balls = new BowlingBall[6];

            for (int i = 0; i < 6; i++)
            {
                balls[i] = Pool.GetObject();
                Score+=balls[i].Throw();
            }

            for (int i = 0; i < 5; i++)
            {
                Pool.ReleaseObject(balls[i]);
            }



            

            

            Console.WriteLine(Score);
        }
    }
}
