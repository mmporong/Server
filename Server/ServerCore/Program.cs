using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static object _lock = new object();
        static SpinLock _lock2 = new SpinLock();
        static Mutex _lock3 = new Mutex();

        class Reward
        {

        }

        static ReaderWriterLockSlim _lock4 = new ReaderWriterLockSlim();

        static Reward GetRewardById(int id)
        {
            _lock4.EnterReadLock();
            _lock4.ExitReadLock();

            lock (_lock)
            {

            }
            return null; 
        }

        static void AddReward(Reward reward)
        {
            _lock4.EnterWriteLock();
            _lock4.ExitWriteLock();
        }

        static void Main(string[] args)
        {
            lock (_lock)
            {

            }

            bool lockTaken = false;
            try
            {
                _lock2.Enter(ref lockTaken);

            }
            finally
            {
                if (lockTaken)
                    _lock2.Exit();

            }
        }
    }
}


