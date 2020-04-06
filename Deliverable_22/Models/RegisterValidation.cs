using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverable_22.Models
{
    public class RegisterValidation
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public int PhoneType { get; set; }
        public bool CheckBox { get; set; }
    }
}

