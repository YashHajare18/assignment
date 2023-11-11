using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_EMP_INmemory
{
    internal class CURD_Class : IEmployeeRepository
    {
        List<Employee> emplist;
        public CURD_Class() { }
        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
