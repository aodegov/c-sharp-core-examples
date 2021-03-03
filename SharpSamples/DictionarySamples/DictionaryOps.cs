using System.Collections.Generic;

namespace DictionarySamples
{
    public class DictionaryOps
    {
        private Dictionary<string, List<string>> Data = new Dictionary<string, List<string>>();
        public void DoAdd(string key, string value)
        {
           if(!Data.TryAdd(key, new List<string>{value}))
            {
                Data[key].Add(value);
            }
        }

        public bool DoRemove(string key, string valueToRemove)
        {
            if (Data.ContainsKey(key))
            {
                var isRemoved = Data[key].Remove(valueToRemove);
                return (bool)isRemoved;
            }
            return false;
        }
    }
}
