using System;


namespace IntroductiontoCsharp_assignment
{
    internal class Swapnumbers
    {
        public static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swaping");
            Console.WriteLine("First number" + num1);
            Console.WriteLine("second number" + num2);
            Console.ReadLine();
        }
    }
}
