using System;
using System.Threading;

namespace MultiThreading.Classic
{

    public class MyThread
    {

        public void Thread1()
        {
            Console.WriteLine(Thread.GetDomain());

            for (int i = 0; i <= 10; i++)
            {

                Thread thr = Thread.CurrentThread;
                Console.WriteLine(i);
            }
        }

    }
}
