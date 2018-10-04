using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeDemo
{
    [Serializable]
    [Author("Utkarsh Upadhyay")]                 
    //[Author("ABC")]                        AllowMultiple = true
    public class Product
    {
        //[Author("Utkarsh Upadhyay")]            
        public int ProdID { get; set; }
        public string Prodname { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price) { }

        public void ShowProduct() { }

    }
}
