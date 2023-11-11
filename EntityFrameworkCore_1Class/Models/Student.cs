using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_1Class.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set;}
        public DateTime? DateOfBirth { get; set; }
        public string? Photo {  get; set; }
        public string? Address { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string? Email { get; set; }
        public  int? GreadId { get; set; }
        public Grade? Grade { get; set;}
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", FirstName, LastName, DateOfBirth, Height, Weight,GreadId,Photo,Address,Email);
        }
    }
}
