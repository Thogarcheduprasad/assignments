using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace adodemo
{
    internal class Curdoperation
    {
        public static void Main(string[] args)
        {
            SqlConnection con;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            con.Open();
            Console.WriteLine("Connection is Established");
            try
            {
                char say;
                do
                {
                    Console.WriteLine("Choose your choice :\n 1.Insertion \n 2.Retrive \n 3.Update \n 4.Delete");
                    int Choice = int.Parse(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine("Enter employee id");
                            int empid = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Enter employee first name");
                            string empfirstname = Console.ReadLine();
                            Console.WriteLine("Enter Employee last name");
                            string emplastname = Console.ReadLine();
                            Console.WriteLine("Enter Employee email");
                            string empemail = Console.ReadLine();
                            Console.WriteLine("Enter employee department id");
                            int departmentid = int.Parse(Console.ReadLine());
                            string insertqery = "SET IDENTITY_INSERT Employee ON INSERT INTO Employee(Empid,EmpFirstName,EmpLastName,EmpEmail,Departmentid) VALUES (" + empid +  "','" + empfirstname + "','" + emplastname + "','" + empemail + "','" + departmentid + "' +)";


                            SqlCommand insertcomm = new SqlCommand(insertqery, con);
                            insertcomm.ExecuteNonQuery();

                            Console.WriteLine("Data successfully inserted into a table");
                            break;
                        case 2:
                            //Retrive
                            string retrive = "select * from Employee";
                            SqlCommand retrivecomm = new SqlCommand(retrive, con);
                            SqlDataReader empdata = retrivecomm.ExecuteReader();
                            while (empdata.Read())
                            {
                                int emid = Convert.ToInt32(empdata["Empid"]);
                               
                                string emfirstname = Convert.ToString(empdata["Empfirstname"]);
                                string emlastname = Convert.ToString(empdata["Emplastname"]);
                                string ememail = Convert.ToString(empdata["Empemail"]);
                              
                                string emdepartmentid = Convert.ToString(empdata["Departmentid"]);
                                Console.WriteLine(emid + " " + emfirstname + " " + emlastname + " " + ememail + " " + emdepartmentid);

                            }
                            empdata.Close();
                            break;
                        case 3:
                            //Update
                            Console.WriteLine("Enter employee  id for update");
                            int U_Em = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter empid where you want to update");
                            int empidforupdate = int.Parse(Console.ReadLine());
                            string updateqry = "UPDATE EMPLOYEE SET Managerid= " + U_Em + "wher Empid = " + empidforupdate + "";
                            SqlCommand updatecomm = new SqlCommand(updateqry, con);
                            updatecomm.ExecuteNonQuery();
                            Console.WriteLine("Data is successfully updated");
                            break;
                        case 4:
                            //Delete
                            Console.WriteLine("enter employee id for delete particular row");
                            int empidfordelete = int.Parse(Console.ReadLine());
                            string deleteqry = "DELETE FROM EMPLOYEE where Empid=" + empidfordelete + "";
                            SqlCommand deletecomm = new SqlCommand(deleteqry, con);
                            deletecomm.ExecuteNonQuery();
                            Console.WriteLine("data is successfully delete in a table");
                            break;
                        default:
                            Console.WriteLine("Invaalid input");
                            break;






                    }
                    Console.WriteLine("do you want continue: (Y/S)");
                    say = Convert.ToChar(Console.ReadLine());

                } while (say == 'y');

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
    }
}
