using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Assingment.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Double? Salary {  get; set; }
        public int? DeptId { get; set; }
        public Department? Department { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Name, Salary, DeptId);
        }

    }
}
