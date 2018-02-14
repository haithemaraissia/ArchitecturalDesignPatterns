using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultiThreading.Classic;
using MultiThreading.Current;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classic
            // InitMyThread();
            // InitClassicMulti();

            //Update
            Task.Run(InitAsyncDownloader);
            Console.ReadLine();
        }




        #region Updated

        private static async Task InitAsyncDownloader()
        {
            var urlList = new List<string>
            {
                "http://www.google.com",
                "http://www.bakemag.com"
            };

            foreach (var url in urlList)
            {
                string html = await Downloader.DownloadHtml(url);
                Console.WriteLine("HTML CONTENT " + html);
            }
        }
        #endregion

        #region Classic

        #region MyThread

        private static void InitMyThread()
        {
            Console.WriteLine("Before start thread");

            MyThread thr1 = new MyThread();

            Thread tid1 = new Thread(new ThreadStart(thr1.Thread1));

            tid1.Start();
        }

        #endregion

        #region ClassicMultiThread

        private static void InitClassicMulti()
        {
            Thread T1 = new Thread(ClassicMultiThread.Test1);
            Thread T2 = new Thread(ClassicMultiThread.Test2);
            Thread T3 = new Thread(ClassicMultiThread.Test3);

            T1.Start();
            T2.Start();

            Console.WriteLine("Main Thread is exiting");

            Console.WriteLine("Using Task");
            Task Task1 = new Task(ClassicMultiThread.Test1);
            Task Task2 = Task1.ContinueWith((previousTask) =>
            {
                ClassicMultiThread.Test2();
            }, TaskScheduler.Current);
            Task1.Start();
        }

        #endregion

        #endregion

    }
}
