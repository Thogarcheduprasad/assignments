using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Sample
    {


        public static void Main()
        {
            Stack<String> ss = new Stack<string>();
            ss.push("Prasad");
            ss.push("subbu");
            ss.push("venkatesh");
            Console.WriteLine(ss.pop());
            Console.WriteLine(ss.pop());
            Console.WriteLine(ss.pop());
            Console.WriteLine(ss.pop());
            Console.ReadKey();

        }
    }
    public class Stack<T>
    {
        public int size;
        public StackElement<T> top;
        public Stack()
        {
            size = 0;
            top = null;
        }
        public void push(T newvalue)
        {
            StackElement<T> newElement = new StackElement<T>(newvalue, top);
            top = newElement;
            size++;
        }

        public T pop()
        {
            StackElement<T> oldTop = top;

            if (size == 0)
            {
                return default(T);
                Console.WriteLine("Stack is Empty");
            }
            //try
            //{
            top = top.getNext();
            return oldTop.getValue();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

    }
    public class StackElement<T>
    {
        public T value;
        public StackElement<T> next;

        public StackElement(T value, StackElement<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public StackElement<T> getNext()
        {
            return next;
        }
        public T getValue()
        {
            return value;
        }


    }
}
