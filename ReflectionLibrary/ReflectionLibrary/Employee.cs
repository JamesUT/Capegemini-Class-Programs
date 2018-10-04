using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLibrary
{
    public class Employee
    {
        int id;
        public int EmpID { get{return id;} set{id=value;} }

        string name;
        public string Name { get { return name; } set { name = value; } }

        double salary;
        public double Salary { get { return salary; } set { salary = value; } }

        public Employee()
        { 
        }

        public Employee(int id, string name, double salary) { }
    }
}
