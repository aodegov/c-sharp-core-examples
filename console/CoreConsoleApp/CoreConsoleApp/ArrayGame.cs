using System;
namespace CoreConsoleApp
{
    public class ArrayGame
    {
        private string _ORIGINAL;
        public ArrayGame()
        {
            _ORIGINAL = "Check as Array";
        }

        public void CheckStringHash()
        {
            var COPY = _ORIGINAL.ToUpper();
            Console.WriteLine($"ORIGINAL: {_ORIGINAL.GetHashCode()} COPY:{COPY.GetHashCode()}");
        }
    }
}
