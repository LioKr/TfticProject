using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class RegisterInfo
    {
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength (50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(2)]
        public string Role { get; set; }
    }
}