using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTuple = Cortege(25, "Alexandr");
            Console.WriteLine("{0}\n25 Squared: {1}\nSquare root of 25: "
                + "{2}\nFirst symbol in name: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);

            // Создаем кортеж произвольной размерности
            var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short, Tuple<int,
                float, string, char, Test>>(12, 'C', "Name", 12.3892m, 0.5f, 120, 4501, myTuple);

            Console.ReadLine();
        }
        
        // Данный метод возвращает кортеж с 4-мя
        // разными значениями
        static Tuple<int, float, string, char, Test> Cortege(int a, string name)
        {
            int sqr = a * a;
            float sqrt = (float)(Math.Sqrt(a));
            string s = "Hello, " + name;
            char ch = (char)(name[0]);

            return Tuple.Create<int, float, string, char, Test>(sqr, sqrt, s, ch, new Test());
        }

        internal class Test
        {

        }
    }
}
