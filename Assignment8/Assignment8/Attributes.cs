
using System;
using System.Reflection;
namespace reflectionApp
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property, AllowMultiple = true)]
    class SoftwareAtttribute : System.Attribute
    {
        private string ProjectName { get; set; }
        private string Description { get; set; }
        private string ClientName { get; set; }
        private string StartedDate { get; set; }
        private string EndDate { get; set; }
        public string projectName { get; set; }
        //{
        //    get { return ProjectName; }
        //    set { ProjectName = value; }
        //}
        //public string description
        //{
        //    get { return Description; }
        //    set { Description = value; }
        //}
        //public string clientName
        //{
        //    get { return ClientName; }
        //    set { ClientName = value; }
        //}
        //public string startedDate
        //{
        //    get { return StartedDate; }
        //    set { StartedDate = value; }
        //}
        //public string endDate
        //{
        //    get { return EndDate; }
        //    set { EndDate = value; }
        //}
        public class HDFCAccount : SoftwareAtttribute
        {
            public void displayAccount(string projectName, string description, string clientname)
            {
                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                Console.WriteLine("Project Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);

            }
        }
        public class ICICIAccount : SoftwareAtttribute
        {
            public void displayAccount(string description, string projectName, string clientname, string startedDate, string enddate)
            {
                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                this.StartedDate = startedDate;
                this.EndDate = enddate;
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + StartedDate);
                Console.WriteLine("Project End Date : \n" + EndDate);
            }
        }



        class Test
        {
            static void Main(string[] args)
            {
                HDFCAccount ha = new HDFCAccount();
                ha.displayAccount("reflection assignment", "reflection", "capgemini");
                ICICIAccount ia = new ICICIAccount();
                ia.displayAccount("reflection assignment", "reflection", "capgemini", "17-04-2022", "18-04-2022");
                Assembly executing = Assembly.GetExecutingAssembly();
                Type[] types = executing.GetTypes();
                foreach (Type t in types)
                {
                    MethodInfo[] mi = t.GetMethods();
                    foreach (var m in mi)
                    {
                        Console.WriteLine(m);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
