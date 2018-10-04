using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo file = new FileInfo(@"C:\Users\uupadhya\Desktop\utkarsh\Programs\add.cs");        //String Interpolation is done using @/$

            string filename;

            Console.Write("Enter File name with full path : ");

            filename = Console.ReadLine();

            FileInfo file = new FileInfo(filename);

            if (file.Exists)
            {
                Console.WriteLine("File name :" + file.Name);
                Console.WriteLine("File Attributes :" + file.Attributes);
                Console.WriteLine("File Creation Time :" + file.CreationTime);
                Console.WriteLine("File CreationTimeUtc :" + file.CreationTimeUtc);
                Console.WriteLine("File Directory :" + file.Directory);
                Console.WriteLine("File DirectoryName :" + file.DirectoryName);
                Console.WriteLine("File Exists :" + file.Exists);
                Console.WriteLine("File Extension :" + file.Extension);
                Console.WriteLine("File FullName :" + file.FullName);
                Console.WriteLine("File Length :" + file.Length);
                Console.WriteLine("File name :" + file.IsReadOnly);
                Console.WriteLine("File name :" + file.LastAccessTime);
                Console.WriteLine("File name :" + file.LastAccessTimeUtc);
                Console.WriteLine("File name :" + file.LastWriteTime);
                Console.WriteLine("File name :" + file.LastWriteTimeUtc);
                
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }
            Console.ReadKey();
        }
    }
}
