using System;
namespace calapp
{
    class Calculator
    {
        public static void Main(string[] args)
        {



            int num1 = 0; int num2 = 0;

            Console.WriteLine("Calculator");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the option following list");
            Console.WriteLine("\t1  -add");
            Console.WriteLine("\t2 -Sub");
            Console.WriteLine("\t3 -multiplication");
            Console.WriteLine("\t4  -Division");
            Console.WriteLine("your option");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"your result : {num1} + {num2} =" + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"your result : {num1} - {num2} =" + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"your resutl : {num1}*{num2} =" + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"your result : {num1} / {num2} =" + (num1 / num2));
                    break;


            }
            Console.WriteLine("press any key to close calculator");
            Console.ReadKey();


        }
    }
}