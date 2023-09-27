using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanResourceSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public Department Department { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }
    }
}