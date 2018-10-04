using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            intList.Add(10);
            //intList.Add(true);            only integer vales accepted
            //intList.Add(10.012);
            intList.Add(11);
            intList.Add(12);

            foreach (int k in intList)
            {
                Console.WriteLine(k);
            }

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "rOBERT" });
            empList.Add(new Employee() { ID = 102, Name = "ASCHSAC" });
            empList.Add(new Employee() { ID = 103, Name = "ASJCLAJLCS" });

            foreach (Employee k in empList)
            {
                Console.WriteLine(k.ID + "\t" + k.Name);
            }

            Console.ReadKey();
        }
    }
}
