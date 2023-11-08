namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();

    }
}
