using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.web.Models
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Agency { get; set; } = "PXM25397";

        [Required]
        public string User { get; set; } 

        [Required]
        public string Password { get; set; }  
    }
}

