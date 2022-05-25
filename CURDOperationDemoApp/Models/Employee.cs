using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CURDOperationDemoApp.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    public class EFDemoDbEntities : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}