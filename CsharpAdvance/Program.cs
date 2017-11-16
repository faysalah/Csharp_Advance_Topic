using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public delegate TResult Func<in T1,in T2, out TResult>(T1 arg1, T2 arg2);
    public delegate void Action<in T1, in T2>(T1 arg, T2 arg1);

    class Util
    {
        public static void Transform<T>(T[] values, Func<T,T,T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
              values[i] = transformer.Invoke(values[i], values[i]);
            }
        }

        public static void Transform1<T>(T[] values, Action<int, double> transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                transformer(120,55.5);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square);
            Util.Transform1(values, Print);
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        static int Square(int x, int y) { return x * y; }

        static void Print(int x, double y) { Console.WriteLine(x + "-----" + y); }
    }
}
