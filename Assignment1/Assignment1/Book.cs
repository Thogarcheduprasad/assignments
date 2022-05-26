using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum BookType
    {
        Magazine,
        Novel,
        Referencebook,
        Miscellaneous

    }
    class StruBook
    {
        public static void Book()
        {
            int Bookid;
            string Title;
            double Price;

            Console.WriteLine("Enter the BookId");
            Bookid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Title ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the book price");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Book Type");
            Console.WriteLine("1.Magazine");
            Console.WriteLine("2.Novel");
            Console.WriteLine("3.ReferenceBook");
            Console.WriteLine("4.Miscellaneous");

            int type=int.Parse(Console.ReadLine());
            Console.WriteLine("The Book Id " + Bookid);
            Console.WriteLine("the Title of the book is " + Title);
            Console.WriteLine("The price of book is" + Price);
            switch (type)
            {
                case 1:
                    Console.WriteLine("the book type is :" + BookType.Magazine);
                    break;
               case 2:
                    Console.WriteLine("the book type is :" + BookType.Novel);
                    break;
               case 3:
                    Console.WriteLine("the book type is :" + BookType.Referencebook);
                    break;
                case 4:
                    Console.WriteLine("the book type is :" + BookType.Miscellaneous);
                    break;

                    default:
                    Console.WriteLine("selecting from 1 to 4 only");
                    break;


            }
        }
    }
}
