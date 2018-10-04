using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            AuthorAttribute atr = (AuthorAttribute) Attribute.GetCustomAttribute (typeof(Product),typeof(AuthorAttribute));
            if (atr == null)
            {
                Console.WriteLine("Attribute not applied on Product.");
            }
            else
                Console.WriteLine("Author Name for Class Product Is :" + atr.AuthorName);

            Console.ReadKey();
        }
    }
}
