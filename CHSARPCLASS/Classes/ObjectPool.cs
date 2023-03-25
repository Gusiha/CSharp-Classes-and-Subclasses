namespace CHSARPCLASS.Classes
{
    public abstract class ObjectPool<T> where T : class, new()
    {
        protected static readonly object Locker = new();


        protected int restrictor = 10;

        protected List<T> UsedList;
        protected List<T> FreeList;

        protected ObjectPool()
        {
            UsedList = new List<T>();
            FreeList= new List<T>();
        }

        public abstract T GetObject();
        public abstract void ReleaseObject(T obj);

    }


    public class BowlingObjectPool : ObjectPool<BowlingBall>
    {
        private BowlingObjectPool() : base()
        {

        }

        private static BowlingObjectPool instance;

        public static BowlingObjectPool GetInstance()
        {
            if (instance == null)
            {
                lock (Locker)
                {
                    instance ??= new BowlingObjectPool();
                }
            }
            return instance;
        }

        public override BowlingBall GetObject()
        {
            int FreeAmount = FreeList.Count;
            int UsedAmount = UsedList.Count;

            if (FreeAmount == 0)
            {
                if (UsedAmount == restrictor)
                {
                    //TODO Waiting
                }

                else
                {
                    var NewWorker = new BowlingBall();
                    FreeList.Add(NewWorker);
                }
            }

            if (FreeAmount > 0)
            {
                UsedList.Add(FreeList[0]);
                FreeList.RemoveAt(0);
                return UsedList[0];
            }

            else
            {
                throw new Exception("List of free Workers is empty!");
            }
        }

        public override void ReleaseObject(BowlingBall obj)
        {
            if (UsedList.Contains(obj))
            {
                FreeList.Add(obj);
                UsedList.Remove(obj);
            }
        }
    }




}
