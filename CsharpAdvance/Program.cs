using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public delegate T Transformer<T>(T arg);

    //class Util
    //{
    //    public static void Transform<T>(T[] values, Transformer<T> t)
    //    {
    //        for (int i = 0; i < values.Length; i++)
    //        {
    //            values[i] = t.Invoke(values[i],values[i]);
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = Square;

            Console.Read();
        }
        static double Square(double x) { return x * x; }
    }
}
