using System;
namespace LitwareLib
{
    public class Employee
    {
        int Empno;
        string EmpName;
        double Salary, HRA, DA, TA, TDS, PF, GrossSalary, NetSalary;

        public Employee(int eno, string ename, double sal)

        {
            Empno = eno;
            EmpName = ename;
            Salary = sal;



            if (sal < 5000)
            {


                HRA = sal * 10 / 100;
                TA = sal * 5 / 100;
                DA = sal * 15 / 100;

            }
            else if (sal < 10000)
            {
                HRA = sal * 15 / 100;
                TA = sal * 10 / 100;
                DA = sal * 20 / 100;
            }
            else if (sal < 15000)
            {
                HRA = sal * 20 / 100;
                TA = sal * 15 / 100;
                DA = sal * 25 / 100;

            }
            else if (sal < 20000)
            {
                HRA = sal * 25 / 100;
                TA = sal * 20 / 100;
                DA = sal * 30 / 100;

            }
            else if (sal >= 20000)
            {
                HRA = sal * 30 / 100;
                TA = sal * 25 / 100;
                DA = sal * 35 / 100;

            }

        }
        public void CalculatedSalary()
        {
            GrossSalary = Salary + HRA + TA + DA;
            PF = GrossSalary * 0.1;
            TDS = GrossSalary * 0.18;
            NetSalary = GrossSalary - (PF + TDS);





        }

        void Dispaly()
        {
            Console.WriteLine("\n Employee name is-: " + Empno);
            Console.WriteLine("......................................");
            Console.WriteLine("\nID No is-: " + EmpName);
            Console.WriteLine("\nBasic salary is-: " + Salary);
            Console.WriteLine("\nhra is-: " + HRA);
            Console.WriteLine("\nda is -:" + DA);
            Console.WriteLine("\nta is -:" + TA);
            Console.WriteLine("\nGross Salary is -:" + GrossSalary);
            Console.WriteLine("\nNetSalary is -:" + NetSalary);
        }





        static void Main(string[] args)
        {
            Employee emp = new Employee(10, "prasad", 10000);
            emp.CalculatedSalary();
            emp.Dispaly();

            Console.ReadLine();
            Console.ReadKey();








        }
    }
}







