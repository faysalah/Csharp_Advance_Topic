using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    delegate int up();
    class Util
    {
        public int count = 0;

        public int upOne()
        {
            count++;
            return count;
        }

        public int upTwo()
        {
            count = count + 2;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Util util = new Util();
            up p = util.upTwo;
            p += util.upOne;
            Console.WriteLine(p.Target == util);
            Console.WriteLine(p.Method);
            Console.WriteLine(p.Invoke());
            Console.Read();
        }
    }
}
