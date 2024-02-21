using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proje.Domain
{
    public class User
    {
        public int Id { get ; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Status AccountStatus { get; set; } = Status.active;
        public DateTime Created { get; set; } = DateTime.Now;
    }

   
}
