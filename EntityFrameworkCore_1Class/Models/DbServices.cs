using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_1Class.Models
{
    internal class DbServices
    {
        private static readonly SchoolContext db = new SchoolContext(); // created object of class which is inherited from DbContext

        public void Display()
        {
            foreach (var r in db.Student.ToList<Student>())
                Console.WriteLine(r);
        }

        public void Adddata(Student s)
        {
            db.Add<Student>(s); //inherited from DbConext.
            db.SaveChanges();   //ye line pe query fire hota hai.
        }
        public void Delete(int id)
        {
            Student s = db.Student.FirstOrDefault<Student>((stu) => stu.StudentId == id);
            if (s != null)
            {
                db.Remove<Student>(s);
                db.SaveChanges();
            }


        }
        public List<Student> Customquery(string name)
        {
            FormattableString sql = $"SELECT * FROM Student WHERE FirstName ={name}";
            var studentlist = db.Student.FromSql(sql).ToList();
            return studentlist;


        }

        public void Liqdemo()
        {
            var r = db.Student.Join(db.Grade, (sg) => sg.GreadId, (gi) => gi.Id, (r, g) => new { Name = r.FirstName, Gradename = g.GradeName });
            foreach (var result in r)
            {
                Console.Write(result.Gradename + " ");
                Console.WriteLine(result.Name);

            }
        }
    }
}
