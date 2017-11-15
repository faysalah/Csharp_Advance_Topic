using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    // a Delegate is an object that knows how to call a method.
    delegate int Transformer(int x);
    class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t.Invoke(values[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4 };

            Util.Transform(values, qube);

            foreach (int i in values)
            {
                Console.Write(i+" ");
            }
            Console.Read();
 
        }

        static int square (int x) { return x * x; }

        static int qube(int x){ return x * x * x; }
    }
}
