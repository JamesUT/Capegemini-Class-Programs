using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(20000);
            Console.WriteLine("With Bonus Salary :" + emp.GiveBonus(5000));

            SalesPerson sales = new SalesPerson(20000,215);
            Console.WriteLine("With Bonus Salary :" + sales.GiveBonus(5000));

            Employee empSales = new SalesPerson(20000, 215);
            Console.WriteLine("With Bonus Salary :" + empSales.GiveBonus(5000));

            Console.ReadKey();
        }
    }
}
