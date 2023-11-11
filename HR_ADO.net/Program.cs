using Microsoft.Extensions.Configuration;

namespace HR_ADO.net
{
    internal class Program
    {
        private static IConfiguration configuration;
        private static StronglyType stronglyType;
        static void Main(string[] args)
        {
            GetAppsettings();
            Employee_List();
            Insert_Employee(new Employee { Id=6,Name="Shushil",Address="Kanad",Gender= "Male",Salary="45000" });
            Console.WriteLine("After Adding ONE emp");
            Employee_List();
            Update_Employee(new Employee { Id = 5, Name = "Shubham", Address = "Solapur", Gender = "Male", Salary = "70000" },5);
              Console.WriteLine("After UPDATE ONE emp detaile");
              Employee_List();
            Delete_Employee(4);
           Console.WriteLine("After DELETE ONE emp detaile");
           Employee_List();
            Console.WriteLine("dispay one emp");
            Search_Employee(3);
           
        }

        public static void Search_Employee(int v)
        {
            stronglyType = new StronglyType(configuration);
            Employee emp=stronglyType.Search(v);
            //stronglyType.Search(v);
            //Employee emp=new Employee();

           Console.WriteLine("{0} {1} {2} {3} {4}", emp.Id, emp.Name, emp.Gender, emp.Salary, emp.Address);
            
        }

        public static void Delete_Employee(int v)
        {
            stronglyType = new StronglyType(configuration);
            stronglyType.Delete(v);
        }

        public static void Update_Employee(Employee e,int Id)
        {
           stronglyType = new StronglyType(configuration);
            stronglyType.Updte(e, Id);

        }

        public static void Insert_Employee(Employee emp)
        {
             stronglyType = new StronglyType(configuration);
            stronglyType.Insert(emp);

        }

        public static void Employee_List()
        {
             stronglyType=new StronglyType(configuration);
            List<Employee> employee = stronglyType.GetList(); 
            foreach (Employee emp in employee) 
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",emp.Id,emp.Name,emp.Gender, emp.Salary, emp.Address);
            }
        }

        public static void GetAppsettings()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            configuration= builder.Build();
        }
    }
}