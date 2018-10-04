using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo3
{
    public class Employee
    {
        int id;
        string name;
        double salary;

        public int EmployeeID { get { return id; } }
        public string EmployeeName { get { return name; } }
        public double Salary { get { return salary; } }

        public Employee(int id, string name, double salary)
        {
            //id = id;
            //name = name;
            //salary = salary;

            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}
