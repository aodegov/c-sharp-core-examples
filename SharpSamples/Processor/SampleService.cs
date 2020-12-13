using DictionarySamples;
using System;

namespace SamplesProcessor
{
    public class SampleService
    {
        public void DoWork()
        {
            try
            {
                // StringOps so = new StringOps();
                // var str = so.StringFormatOps();

                var key = Guid.NewGuid().ToString();
                DictionaryOps doOps = new DictionaryOps();
                doOps.DoAdd(key, Guid.NewGuid().ToString());
                doOps.DoRemove(key, Guid.NewGuid().ToString());
                doOps.DoAdd(key, Guid.NewGuid().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
