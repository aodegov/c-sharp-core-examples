using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class ConcurrentCollection
    {
        public ConcurrentCollection()
        {
      
        }

        public async void Foo()
        {
            Console.WriteLine($"Foo Id: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Foo");
            void Boo()
            {
                Console.WriteLine("Boo");
            }
            Boo();
            await TestAsync();
        }

        private async Task TestAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine($"Test Async: {Thread.CurrentThread.ManagedThreadId}");
        }

        public void RunConcurrency()
        {
            Console.WriteLine($"Run Id: {Thread.CurrentThread.ManagedThreadId}");
            Foo();
            List<int> lst = new List<int>();
            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1 has started");
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"Thread 1. List update. Added {i}");
                    lst.Add(i);
                }
                Console.WriteLine("Thread 1 is completed");
            });

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2 has started");
                for (int i = 11; i < 21; i++)
                {
                    Console.WriteLine($"Thread 2. List update. Added {i}");
                    lst.Add(i);
                }
                Console.WriteLine("Thread 2 is completed");
            });


            Thread t3 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                Console.WriteLine("Thread 3 has started");
                foreach (var item in lst)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thread 3 is completed");
            });

            t1.Start();
            t2.Start();
            t3.Start();
            Thread.Sleep(988);
        }
    }
}
