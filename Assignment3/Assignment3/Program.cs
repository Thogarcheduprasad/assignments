using System;
class Employee
{
    protected int Empid { get; set; }
    protected string EmpName { get; set; }
    protected double Salary { get; set; }
    protected double HRA { get; set; }
    protected double TA { get; set; }
    protected double DA { get; set; }
    protected double PF { get; set; }
    protected double TDS { get; set; }

    protected double NetSalary { get; set; }

    protected double GrossSalary { get; set; }

    public Employee(int Empnum, string Ename, double Sal)
    {
        Empid = Empnum;
        EmpName = Ename;
        Salary = Sal;
    }

}
class Manager : Employee
{
    private double Petrolallow { get; set; }
    private double Foodallow { get; set; }
    private double Otherallow { get; set; }


    public Manager(int Empnum, string Ename, double Sal) : base(Empnum, Ename, Sal)
    {
        Petrolallow = Sal * 8 / 100;
        Foodallow = Sal * 13 / 100;
        Otherallow = Sal * 3 / 100;
    }
    public virtual void Gsal()
    {

        GrossSalary = GrossSalary + Petrolallow + Foodallow + Otherallow;
        Console.WriteLine(GrossSalary);
    }
    public virtual void Calsal()
    {
        //base.Calsal();
        NetSalary = GrossSalary - (PF + TDS);
        Console.WriteLine(NetSalary);
    }


}
class MarketingExe : Employee
{
    private double Kilotra { get; set; }
    private double Tourallow { get; set; }
    private double Telephone { get; set; }

    public MarketingExe(int Empnum, string Ename, double Sal, double Kila) : base(Empnum, Ename, Sal)
    {
        Kilotra = Kila;
        Tourallow = Kilotra * 5;
        Telephone = 1000;
    }
    public virtual void Gsal()
    {

        GrossSalary = GrossSalary + Tourallow + Telephone;
        Console.WriteLine(GrossSalary);
    }
    public virtual void Calsal()
    {
        NetSalary = GrossSalary - (PF + TDS);
        Console.WriteLine(NetSalary);
    }
}
class Program
{
    static void Main(string[] args)
    {
         Employee emp = new Employee(10, "prasad", 20000);
        // emp.Gsal();
        //emp.Calsal();
        Manager m = new Manager(100, "subbu", 10000);
        m.Gsal();
        m.Calsal();
        MarketingExe exe = new MarketingExe(101, "ravi", 20000, 10);
        exe.Gsal();
        exe.Calsal();
        Console.ReadLine();
    }
}

