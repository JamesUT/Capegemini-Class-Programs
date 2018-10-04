using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//using ReflectionLibrary;

namespace ReflectionApplication
{
    class Program 
    {
        static void Main(string[] args)
        {
            Assembly myAssembely = Assembly.LoadFrom("ReflectionLibrary.dll");

            Type[] types = myAssembely.GetTypes();
            Console.WriteLine("Number of Types :" + types.Length);

            foreach (Type t in types)
            {
                Console.WriteLine("***********************Name of types : " + t.Name);
                Console.WriteLine("Assembly Qualified name : " + t.AssemblyQualifiedName);
                Console.WriteLine("Base Type :" + t.BaseType);
                Console.WriteLine("Contain generic parameter :" + t.ContainsGenericParameters);
                Console.WriteLine("Full Name :" + t.FullName);
                Console.WriteLine("GUID :" + t.GUID);
                Console.WriteLine("Is Abstract :" + t.IsAbstract);
                Console.WriteLine("Is ansi Class :" + t.IsAnsiClass);
                Console.WriteLine("Is Auto Class :" + t.IsAutoClass);
                Console.WriteLine("Is Class :" + t.IsClass);
                Console.WriteLine("Is Enum :" + t.IsEnum);
                Console.WriteLine("Is Generic Parameter :" + t.IsGenericParameter);
                Console.WriteLine("Is Interface :" + t.IsInterface);
                Console.WriteLine("Is not public :" + t.IsNotPublic);
                Console.WriteLine("Is Public :" + t.IsPublic);
                Console.WriteLine("Is Sealed :" + t.IsSealed);
                Console.WriteLine("Is Serializable :" + t.IsSerializable);
                Console.WriteLine("Is Value Type :" + t.IsValueType);
                Console.WriteLine("Namespace :" + t.Namespace);
                
            }
            Console.ReadKey();
        }
    }
}
