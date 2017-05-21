using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EAD_CA2_MiniProject.Model
{
    [NotMapped]
    public class StudentModel
    {
        public int StudentID { get; set; }

        [Required]
        public string StudentName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        public byte[] Photo { get; set; }
        [Required]
        public decimal Height { get; set; }

        [Required]
        public float Weight { get; set; }

        public StudentModel()
        {

        }
        public List<Student> Students = new List<Student>();

        //pagination
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int PagerCount { get; set; }
    }

    public class Student
    {

        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Standard Standard { get; set; }

    }
}