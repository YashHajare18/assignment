using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class department with member id, deptname
namespace EntityFrameworkCore_Assingment.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public IList<Employee> Emp { get; set; }
    }
}
