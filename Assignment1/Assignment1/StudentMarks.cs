using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class StudentMarks
    {
        public static void Main(string[] args)
        {


            int[] arr = new int[5];
            int total = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter " + i + "Student marks :");
                arr[i] = int.Parse(Console.ReadLine());
                total = total + arr[i];
                

            }
            float avg = total / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("Average of students marks {0} ", avg);
            Console.WriteLine("height marks is {0} ", max);

            Console.ReadLine();



    }
    } 
    }

