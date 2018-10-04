using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousMethordDemo
{

     //Annonymous Methord have so many Redirections
    public delegate void AnnonymousDel();
    public delegate void AnnonymousDelParam(int val1,int val2);
    public delegate string AnnonymousDelReturn(string val1, string val2);

    class Program
    {
        public static void show()
        {
            Console.WriteLine("Show Methord called using Delegate.");
        }

        public static void Add(int num1,int num2)
        {
            Console.WriteLine("Output using Add Methord {0} + {1} => {2}" ,num1,num2,(num1+num2));
        }

        static void Main(string[] args)
        {
            //AnnonymousDel del1 = new AnnonymousDel(show);
            AnnonymousDel del1 = show;                              // Different ways to implement Delegate
            del1();

            //AnnonumousMethord
            //AnnonymousDel anDel1 = delegate 
            //{
            //    Console.WriteLine("Annonymous Methord called using Delegate.");
            //};
            //anDel1();
            // AnnonymousMethord Demo Different representation
            AnnonymousDel anDel1 = new AnnonymousDel( delegate
            {
                Console.WriteLine("Annonymous Methord called using Delegate.");
            });
            anDel1();

            AnnonymousDelParam anParam = delegate (int num1,int num2) 
            {
                Console.WriteLine("Output using Annonymous Methord {0} + {1} => {2}",num1,num2,(num1+num2));
            };
            anParam(45,75);

            AnnonymousDelReturn anDelReturn = delegate (string val1, string val2)
            {
                return val1 + " " + val2;
            };
            string result = anDelReturn("Utkarsh", "Upadhyay");
            Console.WriteLine("Output by using Annonymous Methord {0} + {1} => {2}"+ result);
            Console.ReadKey();
        }
    }
}
