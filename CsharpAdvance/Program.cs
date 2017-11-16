using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public interface ITransformer
    {
        int Transform(int x);
    }

    class Util
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t.Transform(values[i]);
            }
        }
    }
    class Square: ITransformer
    {
        public int Transform (int x)
        {
            return x * x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
        
            Util.TransformAll(values,new Square());

            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
