using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int intValue = 100;
            //double doubleValue = 20.5;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);              //Count=1    Capacity = 4
            arrayList.Add(45.89);
            arrayList.Add(false);
            arrayList.Add("Capgemini");     //Count=1    Capacity = 4
            arrayList.Add('D');             //Count=5    Capacity = 8
            arrayList.Add("Utkarsh");
            arrayList.Add(123456);
            arrayList.Add(true);            //Count=8    Capacity = 8   
            arrayList.Add(".Net Batch");    //Count=9    Capacity = 16

            Console.WriteLine("Count :" + arrayList.Count);         //Count= 0
            Console.WriteLine("Count :" + arrayList.Capacity);      //Capacity = 0

            Console.WriteLine("The elements of array are: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i] + "\t");
            }

            object[] objArr = new object[15];

            //CopyTo(Array) - All the elements of arraryList is copied to object
            //arrayList.CopyTo(objArr);


            //CopyTo(array,position) - All the elements of array list is copied to object from position.
            //arrayList.CopyTo(objArr, 4);

            //CopyTo(ArrayListindex,Array,ArrayIndex,numberOfElemensts)
            arrayList.CopyTo(3, objArr , 5,2);

            for (int i = 0; i < objArr.Length; i++)
            {
                if (objArr[i] != null)
                    Console.Write(objArr[i] + "\t");
                else
                    Console.Write("Empty!!" + "\t");
            }

            Console.ReadKey();

        }
    }
}
