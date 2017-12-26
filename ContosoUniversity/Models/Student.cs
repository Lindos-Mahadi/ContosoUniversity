using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
   public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        //[RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name cannot be longer than 50 Characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name cannot be longer than 50 Characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0 : YYYY-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return FirstName + ", " + LastName;
        //    }
        //}

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}