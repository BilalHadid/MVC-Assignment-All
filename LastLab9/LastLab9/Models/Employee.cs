using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LastLab9.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Field Rquired")]
        [Display(Name = "Enter User Name")]
        public string username { get; set; }

        [Required(ErrorMessage = "Field Reqired")]
        public string password { get; set; }

        [Required(ErrorMessage ="Fild Required")]
        [Compare("password", ErrorMessage = "Password doesn't Match")]
        public string againPassword { get; set; }

        [Required(ErrorMessage = "Field Rquired")]
        [Display(Name = "Enter the Real Name")]
        public string realname { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [RegularExpression(".+@.+\\..+",ErrorMessage ="Please Enter A valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Invalid SSN")]

        public string SSN { get; set; }

        [Required(ErrorMessage ="Enter Phone Number")]
        [DataType(DataType.PhoneNumber)]
        
        public string Phone { get; set; }

        [Required(ErrorMessage ="Invalid Zip")]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }

        [RegularExpression("True", ErrorMessage = "You have to accept the term")]
        public bool Agreement { get; set; }

    }
}