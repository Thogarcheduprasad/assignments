using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Assignment7
{
    [Serializable]
    class Manager1
    {
        public int Eid;
        public String EmpName;
        public double Salary;
        public Manager1(int eid, String ename, int esalary)
        {
            Eid = eid;
            EmpName = ename;
            Salary = esalary;
        }


    }

    class ManagerSerAndDec
    {

        public static void Main(string[] args)
        {
            string path = "F:\\Manager.txt";

            Manager1 m = new Manager1(539735, "prasad", 100000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, m);
            stream.Close();

            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //Manager m = (Manager)(formatter.Deserialize(stream));
            //Console.WriteLine(m.Eid);
            //Console.WriteLine(m.EmpName);
            //Console.WriteLine(m.Salary);
            //Console.ReadKey();



        }
    }
}