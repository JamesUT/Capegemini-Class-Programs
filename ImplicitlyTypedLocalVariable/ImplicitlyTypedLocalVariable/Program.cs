using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var val;                                          Implicitly typed Local variables ust be Initialized.
            //var val = null;                                   CannotUnloadAppDomainException assigned null value to a implicitly typed local variable
            //var num = 10.5;                                   Default value is Double
            //num = 5;                                          Can't be done as it can accept only the values of type intialized
            //var a = { 1, 2, 3 };                              Cannot initialze a implicitly typed variable with array-initializer(collections)
            var str = "Capgemini";
            str = null;

            var arr = new int[] {1,2,3,4,5 };

            float f = 34.56f;

            Console.ReadKey();

        }
    }
}
