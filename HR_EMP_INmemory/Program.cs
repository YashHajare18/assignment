/*Create database HR with Table Employee having column name Id,Name, Salary,Gender,Address.
Create Interface IEmployeeRepository with following methods
	 Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
Create class which will implement IEmployeeRepository.
In entry class call the method and complete CRUD
Refer next slide for reference
*/


using System.ComponentModel.DataAnnotations;

namespace HR_EMP_INmemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CURD_Class c= new CURD_Class();
            Display(c);
        }

        private static void Display(CURD_Class c)
        {
            throw new NotImplementedException();
        }
    }
}