using ConsoleAppEntity01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace ConsoleAppEntity01
{
    internal class Program
    { 
        static void Main(string[] args)
        {
           DbServices services = new DbServices();
           List<Student> sl= services.Customquery("1St");
            foreach(Student s1 in sl)
                Console.WriteLine(s1);
          
            services.Delete(3);

            Student ss = new Student() { FirstName = "new222", LastName = "sha", DateOfBirth = new DateTime(2001, 12, 15, 0, 0, 0), Photo = "images/a.png", Height = 5, Weight = 58 };
           
            services.Adddata(ss);
            
            services.Display();
            services.Liqdemo();
            

        }

    }
}