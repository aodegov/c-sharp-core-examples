using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class AsyncAwaitTest
    {
        public AsyncAwaitTest()
        {
            // GetDelayAsync();
        }

        public async Task GetDelayAsync()
        {
            Console.WriteLine($"Async Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
            Console.WriteLine($"Async AD Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        } 
    }
}
