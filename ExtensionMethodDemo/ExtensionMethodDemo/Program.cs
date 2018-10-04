using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class StringExtension
    {
        public static string RemoveNonNumeric(this string s)               //"this string s"=>this methord should be attached with string class
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                    sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string phone = "123-1234-12345";

            //StringExtension se = new StringExtension();
            //Console.WriteLine(StringExtension.RemoveNonNumeric(phone));

            Console.WriteLine(phone.RemoveNonNumeric());

            Console.ReadKey();
        }
    }
}
