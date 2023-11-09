﻿namespace Mvc_with__Entity.Models
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly Appdbcontext context;
        public EmployeeService(Appdbcontext context)
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null) 
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id); 
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           // context.Update(employee);
            context.SaveChanges();
            return employeeChanges;

        }
    }
}
