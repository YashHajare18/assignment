using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntity01.Models
{
    public class Student
    {
        public int StudentId { get; set; }
       
        public string? FirstName { get; set; }
       
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Photo { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }

        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2},{3}, {4}, {5} {6}", FirstName, LastName, DateOfBirth, Photo, Height, Weight, GradeId);
        }

    }

}
