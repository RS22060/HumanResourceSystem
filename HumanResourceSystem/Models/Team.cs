using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanResourceSystem.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public Employee Lead { get; set; }

        public IEnumerable<Employee> Members { get; set; }
    }
}