using System;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Div(123));
        }

        static int Div(int num)
        {
            return num != 0 ? (num % 10 + Div(num / 10)) : 0;
        }
    }
}
