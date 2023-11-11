using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DB_First.Models;

[Table("Grade")]
public partial class Grade
{
    [Key]
    public int Id { get; set; }

    public string? GradeName { get; set; }

    public string? Section { get; set; }

    [InverseProperty("Gread")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
