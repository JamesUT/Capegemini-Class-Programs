using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssymetricAccessorPropertiesDemo
{
    class Employee
    {
        int empid;
        public int EmployeeID
        {
            private get { return empid;  }
            set { empid = value; }
        }
        String name;
        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }
        double sal;
        public double EmployeeSal
        {
            get { return sal; }
            private set { sal = value; }
        }
    }
}
