using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsExample.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Display()]
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
    }
}
