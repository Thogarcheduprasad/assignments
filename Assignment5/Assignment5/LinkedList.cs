using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class LinkedList
    {
        class Employees
        {
            public int epno;
            public string epnam;
            public double epsal;

            public Employees(int epno, string epnam, double epsal)
            {
                this.epno = epno;
                this.epnam = epnam;
                this.epsal = epsal;
            }
        }

        class LikedListOfEmployee
        {
            public static void Main()
            {

                List<Employees> l = new List<Employees>(5);

                l.Add(new Employees(547, "balaram", 40000));
                l.Add(new Employees(548, "umesh", 60000));
                l.Add(new Employees(549, "sameer", 20000));
                l.Add(new Employees(550, "sumanth", 100000));

                Console.WriteLine("Number Of Employees In The List" + l.Count());


                Console.WriteLine("Employee Detailes :");
                foreach (var v in l)
                {
                    Console.WriteLine(+v.epno + " " + v.epnam + " " + v.epsal);

                }
                Console.ReadKey();



            }


        }

    }
}
