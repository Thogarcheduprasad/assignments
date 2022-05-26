using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment5
{

    class CollectionArrayList
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("balaram");
            al.Add("sumanth");
            al.Add("umesh");
            al.Add("pavan");
            al.Add("sharath");
            al.Add("sameer");
            al.Add("uday");
            al.Add("prasad");
            al.Add(547);
            Console.WriteLine(al.Capacity);

            foreach (object o in al)
            {
                Console.WriteLine(o);

            }

            Console.ReadKey();
        }
    }

}
