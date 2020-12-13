using SamplesProcessor;
using System;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleService ss = new SampleService();
            ss.DoWork();
        }
    }
}
