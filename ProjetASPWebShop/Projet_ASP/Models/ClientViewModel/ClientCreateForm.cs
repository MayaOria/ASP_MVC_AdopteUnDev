using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.ClientViewModel
{
    public class ClientCreateForm
    {
     
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de famille : ")]
        public string CliName { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom : ")]
        public string CliFirstName { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(5)]
        [EmailAddress]
        [DisplayName("Adresse e-mail : ")]
        public string CliMail { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de l'entreprise : ")]
        public string CliCompany { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        [DisplayName("Login (min 4 caractères : ")]
        public string CliLogin { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string CliPassword { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(CliPassword))]
        [DisplayName("Confirmez le mot de passe : ")]
        public string ConfirmPass { get; set; }
    }
}
