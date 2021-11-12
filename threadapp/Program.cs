using System;
using System.Threading;

namespace threadapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfThreads = 100;
            int counter = 0;

            for (int i = 0; i < numberOfThreads; i++)
            {
                counter++;
                Thread t = new Thread(() =>
                {
                    Thread.Sleep(1000);
                });
                t.Start();
            }
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} and counter {counter}");
        }
    }
}
