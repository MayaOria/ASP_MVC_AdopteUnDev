using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.DeveloperViewModel
{
    public class DeveloperCreateForm
    {
        
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de famille : ")]
        public string DevName { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom : ")]
        public string DevFirstName { get; set; }
        [Required]
        [DisplayName("Date de naissance : ")]
        [DataType(DataType.Date)]
        public DateTime DevBirthDate { get; set; }
        [DisplayName("Photo : ")]
        [DataType(DataType.ImageUrl)]
        public string DevPicture { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Tarif à l'heure : ")]
        public double DevHourCost { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Tarif au jour : ")]
        public double DevDayCost { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Tarif au mois : ")]
        public double DevMonthCost { get; set; }
        [Required]
        [DisplayName("Adresse email : ")]
        [DataType(DataType.EmailAddress)]
        public string DevMail { get; set; }
        [DisplayName("Catégorie : ")]
        [MaxLength(250)]
        [MinLength(1)]
        public string DevCategPrincipal { get; set; }
    }
}
