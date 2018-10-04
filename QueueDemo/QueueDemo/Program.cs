using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queueObject = new Queue();
            queueObject.Enqueue("Utkarsh");
            queueObject.Enqueue("Upadhyay");
            queueObject.Enqueue("Nothng");
            while (queueObject.Count > 0)
            {
                Console.WriteLine(queueObject.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
