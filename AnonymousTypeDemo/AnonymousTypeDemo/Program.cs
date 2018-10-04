using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeDemo
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { ID = 101,Name = "Robert" };
            object o = new Employee() { ID = 102, Name = "Maria" };
            //((Employee)o).ID
            //((Employee)o).Name
            var v = new Employee() { ID = 103, Name = "Reena" };

            object person = new { personName = "Allister", Age = 30 };
            var person1 = new { personName = "Jason", Age = 30 };
            var person2 = new { personName = "Tennyson", Age = 30 };
            var person3 = new { Age = 30 , personName = "Daniel" };

            Console.ReadKey();

        }
    }
}
