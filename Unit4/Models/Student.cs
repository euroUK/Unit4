using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unit4.Models
{
    [Table("Student", Schema = "dbo")]
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public string IdNumber { get; set; }
        public Group Group { get; set; }
    }
}
