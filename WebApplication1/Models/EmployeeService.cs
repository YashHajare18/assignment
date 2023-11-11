namespace WebApplication1.Models
{
    public class EmployeeService : IEmployeeRepository
    {
        private static IEnumerable<Employee> _employeeList;

        public EmployeeService()
        {
            _employeeList = new List<Employee>(){
            new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@CDACtech.com" },
            new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@CDACtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@CDACtech.com" },
    };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;

        }
    }
}
