using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeDemo
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class AuthorAttribute : Attribute
    {
        public string AuthorName { get; set; }

        public AuthorAttribute(string name)
        {
            AuthorName = name;
        }
    }
}
