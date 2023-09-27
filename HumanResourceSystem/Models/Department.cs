using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanResourceSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Title { get; set; }

        public List<Employee> Employees { get; set; }

        public Employee Manager { get; set; }

        public IEnumerable<Team> Teams { get; set; }
    }
}