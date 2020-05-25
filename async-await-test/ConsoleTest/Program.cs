using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var th = Thread.CurrentThread;
            Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            AsyncAwaitTest asyncAwaitTest = new AsyncAwaitTest();
            await asyncAwaitTest.GetDelayAsync();
            Console.WriteLine($"Main Thread Id AD: {Thread.CurrentThread.ManagedThreadId}");
            Console.Read();

            //ConcurrentCollection cc = new ConcurrentCollection();
            //cc.RunConcurrency();

            //A a = new A();
            //a.ShowMessage();

            //B b = new B();
            //b.ShowMessage();

            //A a2 = new B();
            //a2.ShowMessage();

            //A a3 = (A)new B();
            //a3.ShowMessage();
        }
    }

    class A
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("Class A");
        } 
    }

    class B : A
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Class B");
        }
        
    }
} 
