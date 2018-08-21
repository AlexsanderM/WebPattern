using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPattern.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name of the requred")]
        [Display(Name = "Name")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "Name length less 100, more 2")]
        public string FirstName { get; set; }

        public int Age { get; set; }
    }
}
