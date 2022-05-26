using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment7
{
    class Readandwrite
    {


        public static void WriteFile(string filewrite)
        {
            File.WriteAllText(filewrite, "Hello Guys");

        }

        public static void readFile(string filewrite)
        {
            Console.WriteLine(File.ReadAllText(filewrite));

        }

    }


    class Fileio
    {
        public static void Main()
        {
            String fl = @"F:\Sample";
            Readandwrite.WriteFile(fl);

            Readandwrite.readFile(fl);



            DirectoryInfo dir = new DirectoryInfo(@"F:\");
            Console.WriteLine(dir.Exists);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastAccessTimeUtc);
            Console.WriteLine(dir.LastWriteTime);
            Console.WriteLine(dir.LastWriteTimeUtc);
            Console.WriteLine(dir.Name);




            Console.ReadKey();

        }
    }
}


