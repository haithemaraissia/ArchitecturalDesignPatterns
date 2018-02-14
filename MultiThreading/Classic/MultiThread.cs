using System;
using System.Threading;

namespace MultiThreading.Classic
{
    public static class ClassicMultiThread
    {
        public static void Test1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread1 is exiting");
        }

        public static void Test2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Test2:" + i);

                if (i == 50)
                {
                    Console.WriteLine("Thread2 is going to Sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread2 woke up");
                }

            }
            Console.WriteLine("Thread2 is exiting");
        }

        public static void Test3()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread3 is exiting");
        }
    }
}
