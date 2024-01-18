using System;
using System.Threading;

namespace ThreadProgram
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("ThreadProcess: {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1000);
            }

            t.Join();
            Console.ReadKey();
        }
    }
}
