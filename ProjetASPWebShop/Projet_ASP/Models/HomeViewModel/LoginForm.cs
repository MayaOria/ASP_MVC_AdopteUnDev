using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.HomeViewModel
{
    public class LoginForm
    {
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        [EmailAddress]
        [DisplayName("Login :")]
        public string CliLogin { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe:")]
        public string CliPassword { get; set; }
    }
}
