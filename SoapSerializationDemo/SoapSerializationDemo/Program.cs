using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace SoapSerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmpID = 101, Name = "Robert", Salary = 3000.0 };
            FileStream fs = new FileStream("binary.txt", FileMode.Create, FileAccess.Write);
            SoapFormatter sop = new SoapFormatter();
            sop.Serialize(fs,emp);
            fs.Close();
            Console.WriteLine("Serialization Done.");

            fs = new FileStream("binary.txt", FileMode.Open, FileAccess.Read);
            Employee anotherEmp = (Employee)sop.Deserialize(fs);
            fs.Close();

            Console.WriteLine("Employee ID : " + anotherEmp.EmpID);
            Console.WriteLine("Employee name :" + anotherEmp.Name);
            Console.WriteLine("Employee Salary :" + anotherEmp.Salary);

            Console.ReadKey();
        }
    }
}
