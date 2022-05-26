using System;

namespace assignment1
{
    internal class Areaofcircle
    {
        public static void Main()
        {
            double r, cir,arr;
            double PI = 3.14;
            Console.WriteLine("input the raduis of the circle");
            r = Convert.ToDouble(Console.ReadLine());
            cir = 2 * PI * r;
            Console.WriteLine("Parameter of {0} circle" + cir);
            arr = PI * r * r;
            Console.WriteLine("Area Of Circle"+arr);
            Console.ReadLine();
        }
    }
}
