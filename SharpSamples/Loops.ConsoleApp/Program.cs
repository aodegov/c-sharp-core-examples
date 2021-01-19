using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Loops.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] ints = new int[1000000];
            int j;
            for (int i = 0; i < 1000000; i++)
            {
                i = i*2;
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            stopWatch.Start();

            ints = new int[1000000];
            int x;
            foreach (int i in ints)
            {
                x = i*2;
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadLine();
        }
    }
}
