namespace CHSARPCLASS.Classes
{
    public class BowlingBall
    {
        Random random = new Random();

        public int Throw()
        {
            return random.Next(10);
        }

        public BowlingBall()
        {

        }
    }
}
