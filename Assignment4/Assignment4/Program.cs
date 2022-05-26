using System;

class Stack : ApplicationException
{
    protected int max;
    public int[] ele;
    private int top = -1;
    protected int i;


    public void push()
    {
        try
        {
            Console.WriteLine("enter size of an array");
            max = Convert.ToInt32(Console.ReadLine());
            if (max >= 5)
            {
                throw new IndexOutOfRangeException("out of range");
                return;
            }
            ele = new int[max];
            Console.WriteLine("enter elements");
            for (i = 0; i < max; i++)
            {
                ele[i] = Convert.ToInt32(Console.ReadLine());

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        foreach (int b in ele)
        {
            if (top >= max)
            {

                Console.WriteLine("stackoverflow");
                return;
            }

            else
            {
                ele[++top] = b;
            }
        }
    }
    public int pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            Console.WriteLine("Poped element is: " + ele[top]);
            return ele[top--];
        }
    }
}
class Program
{
    static void Main()
    {
        Stack S = new Stack();
        S.push();
        Console.WriteLine("Items are : ");
        S.pop();
        S.pop();
        Console.ReadLine();
    }
}