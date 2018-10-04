using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"Utkarsh");
            //ht.Add(1, "abc");
            ht.Add(2, "Upadhyay");
            //ht.(null, "Hydrabad");
            ht.Add(3, "Megha");
            ht.Add(4, "Nikhil");
            ht.Add(5, null);

            Console.WriteLine("Hash Table Values");
            foreach (int k in ht.Keys)                      //We cannot use just "ht"
            {
                Console.Write("Key :" + k + "\t");
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();
        }
    }
}
