using EntityFrameworkCore_1Class.Models;

namespace EntityFrameworkCore_1Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices db = new DbServices();
            db.Display();
            
            Console.WriteLine("__________________________________________________________--");
            //Student ss = new Student() { FirstName = "shubham", LastName = "hajare", DateOfBirth = new DateTime(1995, 11, 07, 0, 0, 0), Height =6, Weight = 58 };
           // db.Adddata(ss);
            db.Display();
            Console.WriteLine("__________________________________________________________--");
           // db.Delete(1005);
            db.Display();
            Console.WriteLine("__________________________________________________________--");
            var list= db.Customquery("Jay");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            db.Liqdemo();

        }
    }
}