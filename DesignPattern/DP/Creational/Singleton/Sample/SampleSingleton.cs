using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Creational.Singleton.Sample
{
    //eager initialization of singleton
    public class Singleton
    {
        private static Singleton instance = new Singleton();
        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }
    }

    ////lazy initialization of singleton
    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private LazySingleton() { }

        public static LazySingleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new LazySingleton();

                return instance;
            }
        }
    }

    ////Thread-safe (Double-checked Locking) initialization of singleton
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private ThreadSafeSingleton() { }
        private static object lockThis = new object();

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                        instance = new ThreadSafeSingleton();

                    return instance;
                }
            }
        }
    }


    ///Client
    /// 
    /// class Program

    //static void Main(string[] args)
    //{
    //    Singleton.Instance.Show();
    //    Singleton.Instance.Show();

    //    Console.ReadKey();
    //}

}
