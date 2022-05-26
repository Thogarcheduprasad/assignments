using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class StringArray
    {
        public static void Main()
        {
            Console.WriteLine("Enter Array Size:");
            int size = int.Parse(Console.ReadLine());
            string[] intarry = new string[size];

            string[] intarry2 = new string[size];

            Console.WriteLine("Enter String to the Array:");

            for (int i = 0; i < size; i++)
            {
                intarry[i] = Console.ReadLine();
            }

            Array.Copy(intarry, intarry2, size);

            Console.WriteLine("After Copying :");

            foreach (string b in intarry2)
            {
                Console.WriteLine(b);
                // display sorted array
            }
            //After Sorting

            Array.Sort(intarry);

            Console.WriteLine("After Sorting :");

            foreach (string a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }

            //After clear
            Array.Clear(intarry, 2, 2);


            Console.WriteLine("After Clear Elements in Arrray :");
            foreach (string a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }



            //After Reversing

            Array.Reverse(intarry);
            Console.WriteLine("After Reversing");
            foreach (string a in intarry)
            {
                Console.WriteLine(a);
                // display sorted array
            }

            Console.ReadKey();

        }
    }
}
