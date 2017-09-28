using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ServerValidation.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}