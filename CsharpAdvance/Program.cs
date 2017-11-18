using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ListOfProduct = new List<Product>();
           // IEnumerable<Product> Products = Enumerable.Where(ListOfProduct, x => x.Name == "faysal");
            IEnumerable<Product> Products = ListOfProduct.Where(x => x.Name == "faysal");

            Console.ReadKey();
        }
    }
}