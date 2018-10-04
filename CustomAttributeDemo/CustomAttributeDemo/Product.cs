using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeDemo
{
    [Serializable]
    [Author("Shital Patil")]
    //[Author("ABC")]
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price) { }

        [Author("Shital Patil")]
        public void ShowProduct() { }
    }
}
