using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoDemo.Interfaces;

namespace AdoDemo.Entities
{
    public class Employee
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public decimal? Salary { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? City { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
