using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Mystack
    {
        static readonly int max = 100;
        int top1;
        int[] st=new int[max];


        public void Push(int data)
        {
            if (top1 > max)
            {
                Console.WriteLine("Stack Overflow");

            }
            else
            {
                top1 = max;

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Mystack ms=new Mystack();
                ms.Push(10);
                ms.Push(20);
                ms.Push(30);



               

            }
        }

    }
}
