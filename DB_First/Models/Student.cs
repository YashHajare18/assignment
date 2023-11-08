using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DB_First.Models;

[Table("Student")]
[Index("GreadId", Name = "IX_Student_GreadId")]
public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public float? Height { get; set; }

    public float? Weight { get; set; }

    public int? GreadId { get; set; }

    public string? Photo { get; set; }

    [ForeignKey("GreadId")]
    [InverseProperty("Students")]
    public virtual Grade? Gread { get; set; }
}
