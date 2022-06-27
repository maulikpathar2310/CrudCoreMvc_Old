using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpCrudCoreMvc.Models
{
    public class NewEmpClass
    {
        [Key]        
        public int Empid { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Empname { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Empemail { get; set; }

        [Required]
        [Display(Name = "Pass")]
        public string Emppass { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public int  salary { get; set; }

        public bool IsAdmin { get; set; }
    }
}
