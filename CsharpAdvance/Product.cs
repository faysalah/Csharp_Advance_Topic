using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }

    }
    public static class ProductExtend
    {
        public static string UppercaseFirstChar(this string text)
        {
            char[] textarray = text.ToCharArray();
            textarray[0] = Char.ToUpper(textarray[0]);
            foreach (char item in textarray)
            {
                text += item;
            }
            return text;
        }

        public static Product ChangeToDefaultValue(this Product product, string Description)
        {
            product.Id = 000;
            product.Name = "Default_Name";
            product.Desciption = Description;
            return product;
        }
    }
}
