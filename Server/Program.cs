using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    // 메모리 배리어
    // 코드 재배치 억제
    // 가시성
    class Program
    {
        static int number = 0;

        static void Thread_1()
        {
            Interlocked.Increment(ref number);
        }

        static void Thread_2()
        {
            Interlocked.Decrement(ref number);
        }

        static void Main(string[] args)
        {
            Task t1 = new Task(Thread_1);
            Task t2 = new Task(Thread_2);
            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);

            Console.WriteLine(number);
        }
    }
}

