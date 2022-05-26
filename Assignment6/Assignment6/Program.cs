using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{


    public delegate void Employeedelegate(int empid, string empname, double sal);
    public class Employee
    {
        protected int empno { get; set; }
        protected string empname { get; set; }
        protected double Salary { get; set; }
        protected double hra { get; set; }
        protected double ta { get; set; }
        protected double da { get; set; }
        protected double pf { get; set; }
        protected double tds { get; set; }
        protected double netsalary { get; set; }
        protected double grossalary { get; set; }
        public Employee(int empid, string empnm, double sal)
        {
            empno = empid;
            empname = empnm;
            Salary = sal; if (Salary < 5000)
            {
                hra = ((Salary / 100) * 10);
                ta = ((Salary / 100) * 5);
                da = ((Salary / 100) * 15);
                grossalary = Salary + hra + ta + da;
            }
            else if (Salary < 10000)
            {
                hra = ((Salary / 100) * 15);
                ta = ((Salary / 100) * 10);
                da = ((Salary / 100) * 20);
                grossalary = Salary + hra + ta + da;
            }
            else if (Salary < 15000)
            {
                hra = ((Salary / 100) * 20);
                ta = ((Salary / 100) * 15);
                da = ((Salary / 100) * 25);
                grossalary = Salary + hra + ta + da;
            }
            else if (Salary < 20000)
            {
                hra = ((Salary / 100) * 25);
                ta = ((Salary / 100) * 20);
                da = ((Salary / 100) * 30);
                grossalary = Salary + hra + ta + da;
            }
            else
            {
                hra = ((Salary / 100) * 30);
                ta = ((Salary / 100) * 25);
                da = ((Salary / 100) * 35);
                grossalary = Salary + hra + ta + da;
            }
        }
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Employee GrosSalary : " + grossalary); pf = (grossalary / 100) * 10;
            tds = (grossalary / 100) * 18; netsalary = grossalary - (pf + tds); Console.WriteLine("Employee NetSalary : " + netsalary);
        }
    }
    class Manager : Employee
    {
        private double PetrolAllowance { get; set; }
        private double FoodAllowance { get; set; }
        private double OtherAllowance { get; set; }
        public Manager(int empid, string empnm, double sal) : base(empid, empnm, sal)
        {
            PetrolAllowance = Salary * 8 / 100;
            FoodAllowance = Salary * 13 / 100;
            OtherAllowance = Salary * 3 / 100;
        }
        public void CalculateSalary(int empid, string empname, double sal)
        {
            pf = (grossalary / 100) * 10;
            tds = (grossalary / 100) * 18; grossalary = grossalary + PetrolAllowance + FoodAllowance + OtherAllowance;
            Console.WriteLine("manager GrasSalary : " + grossalary); netsalary = grossalary - (pf + tds); Console.WriteLine("Manager Netsalary : " + netsalary);
        }
        public override void CalculateSalary()
        {
            pf = (grossalary / 100) * 10;
            tds = (grossalary / 100) * 18; grossalary = grossalary + PetrolAllowance + FoodAllowance + OtherAllowance;
            Console.WriteLine("manager GrasSalary : " + grossalary); netsalary = grossalary - (pf + tds); Console.WriteLine("Manager Netsalary : " + netsalary);
        }
    }

    class unicastDelegate
    {
        public static void Main()
        {
            Console.WriteLine("Employee Number :");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name :");
            string empname = Console.ReadLine();
            Console.WriteLine("Employee Salary :");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilometertravel :");
            double kmt = Convert.ToDouble(Console.ReadLine());
            Manager m = new Manager(empid, empname, sal);
            Employee e = new Employee(empid, empname, sal);
            Employeedelegate ed = new Employeedelegate(m.CalculateSalary);
            ed(empid, empname, sal);
            Console.ReadKey();
        }
    }




}
