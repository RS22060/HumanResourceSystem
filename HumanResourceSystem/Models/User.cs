using HumanResourceSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanResourceSystem.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public Status Status { get; set; }

        public Gender Gender { get; set; }
    }
}