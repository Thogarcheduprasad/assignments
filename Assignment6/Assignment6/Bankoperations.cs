using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Bankoperations
    {


        class Bank
        {
            private double balance = 50000;
            public double blc
            {
                get { return balance; }
                set { balance = value; }
            }
        }
        class Account
        {
            int Acc_No;
            string Cust_Name;
            double DepositeAmt, WithdraAmt, TotalBal;
            Bank b = new Bank(); public void Deposit()
            {
                Console.WriteLine("Enter Account Number :");
                Acc_No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Depositer of Customer Name :");
                Cust_Name = Console.ReadLine();
                Console.WriteLine("Enter Amount For Deposite :");
                DepositeAmt = int.Parse(Console.ReadLine());
                TotalBal = b.blc + DepositeAmt;
                Console.WriteLine("Customer Account Number :" + Acc_No);
                Console.WriteLine("Customer Name :" + Cust_Name);
                Console.WriteLine("The Total Amount is:" + TotalBal);
            }
            public void Withdraw()
            {
                Console.WriteLine("Enter Account Number :");
                Acc_No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Amount For Withdraw :");
                WithdraAmt = int.Parse(Console.ReadLine()); if (WithdraAmt <= b.blc)
                {
                    TotalBal = b.blc - WithdraAmt;
                    Console.WriteLine("Customer Account Number :" + Acc_No);
                    Console.WriteLine("Customer Name :" + Cust_Name);
                    Console.WriteLine("The Total Amount is:" + TotalBal);
                }
                else
                {
                    Console.WriteLine("Insufficiant Balance :");
                }
            }
        }
        class Banking
        {
            public static void Main()
            {
                char ch;
                do
                {
                    Account a = new Account();
                    int Choose;
                    Console.WriteLine("Please Select The Options");
                    Console.WriteLine("Press 1 For Deposite");
                    Console.WriteLine("Press 2 For Withdraw");
                    Choose = int.Parse(Console.ReadLine()); switch (Choose)
                    {
                        case 1:
                            a.Deposit();
                            break;
                        case 2:
                            a.Withdraw();
                            break;
                        default:
                            Console.WriteLine("Please Enter 1 and 2 Options Only :");
                            break;
                    }
                    Console.WriteLine("if you want to continue:(y/n)?");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch == 'y'); Console.ReadKey();
            }
        }



    }
}
