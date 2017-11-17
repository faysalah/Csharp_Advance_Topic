using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class Program
    {
        public delegate int Transformer(int i, int j);
        
        static void Main(string[] args)
        {
            // Anonymous method 2.0
            Transformer multipication =delegate (int x, int y) { return x * y; };
            Console.WriteLine(multipication.Invoke(3, 6));

            // Lambda expression 3.0
            Func<int, int> sqr = x => x * x;
            Console.WriteLine(sqr(3));

            Func<int, int, int> division = (x,  y) => { return x / y; };
            Console.WriteLine(division(10,2));

            //Lambda expression capturing outer variable
            Func<int> natural = Natural();
            //---vs---
            //Func<int> natural =() => { int seed = 0; return seed++;};
            Console.WriteLine(natural.Invoke());
            Console.WriteLine(natural.Invoke());
            Console.WriteLine(natural.Invoke());
            Console.Read();
        }

        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++;
        }
    }

}
