using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IDeserializationCallbackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new IDeserializationCallbackDemo.Product(101, 30, 23);
            FileStream fs = new FileStream("Prod.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();

            //p.CalculateTotal();

            bin.Serialize(fs, p);
            fs.Close();
            
            fs = new FileStream("Prod.txt", FileMode.Open, FileAccess.Read);
            Product prod = (Product)bin.Deserialize(fs);
            fs.Close();
            
            Console.WriteLine("Product ID :" + prod.prodID);
            Console.WriteLine("Product price :" + prod.Price);
            Console.WriteLine("Product Quantity :" + prod.Quantity);
            Console.WriteLine("Product Total :" + prod.Total);

            Console.ReadKey();
        }
    }
}
