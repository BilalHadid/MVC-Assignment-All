using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabNo._11.Models
{
    [Table("tblstudent")]
    public class student
    {
        [Key]
        public int std_id { get; set; }

        [Required(ErrorMessage ="Student Name Must be Enter")]
        [Display(Name ="Student Name")]
        [MaxLength(40, ErrorMessage ="Student Name Must be 40 character allow")]
        public string sname { get; set; }

        [Required(ErrorMessage = "Student Father Name Must be Enter")]
        [Display(Name = "Father Name")]
        [MaxLength(40, ErrorMessage = "Student Father Name Must be 40 character allow")]
        public string fname { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOA  { get; set; }

        [Required(ErrorMessage ="Password must be required")]
        [DataType(DataType.Password)]
        [MaxLength(15,ErrorMessage ="Password exceed"),MinLength(5,ErrorMessage ="Password atleast 5 char long")]
        public string password { get; set; }

        [Required(ErrorMessage = "Confirm Password must be required")]
        [DataType(DataType.Password)]
        [MaxLength(15, ErrorMessage = "Password exceed"), MinLength(5, ErrorMessage = "Password atleast 5 char long")]
        public string Cpassword { get; set; }
    }
}