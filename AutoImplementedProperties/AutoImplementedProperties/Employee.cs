using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperties
{
    class Employee
    {
        public int EmployeeID { get; set; }     //to make the property read-only or write-only remove the 'set' or 'get' part
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

    }
}
