using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String dirName;

            Console.Write("Enter Directory Name with Full Path :");
            dirName = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(dirName);

            if(dir.Exists)
            {
                Console.WriteLine("Name : " + dir.Name);
                Console.WriteLine("Parent : " + dir.Parent);
                Console.WriteLine("Attributes : " + dir.Attributes);
                Console.WriteLine("CreationTime : " + dir.CreationTime);
                Console.WriteLine("CreationTimeUtc : " + dir.CreationTimeUtc);
                Console.WriteLine("Exists : " + dir.Exists);
                Console.WriteLine("Extension : " + dir.Extension);
                Console.WriteLine("FullName : " + dir.FullName);
                Console.WriteLine("LastAccessTime : " + dir.LastAccessTime);
                Console.WriteLine("LastAccessTimeUtc : " + dir.LastAccessTimeUtc);
                Console.WriteLine("LastWriteTimeUtc : " + dir.LastWriteTimeUtc);
                Console.WriteLine("Root : " + dir.Root);

                DirectoryInfo[] childDir = dir.GetDirectories();
                Console.WriteLine("Number of sub directories :" + childDir.Length);

                for (int i = 0; i < childDir.Length; i++)
                {
                    Console.WriteLine(childDir[i].Name);
                }

                FileInfo[] files = dir.GetFiles();

                Console.WriteLine("\nNumber of Files : " + files.Length);

                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].Name);
                }
            }
            else
            {
                Console.WriteLine("The Directory " + dirName + " does not exists");
            }

            Console.ReadKey();
        }
    }
}
