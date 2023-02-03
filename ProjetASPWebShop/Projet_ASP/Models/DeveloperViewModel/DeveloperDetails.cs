using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.DeveloperViewModel
{
    public class DeveloperDetails
    {
        [DisplayName("Identifiant : ")]
        [ScaffoldColumn(false)]
        public int IdDev { get; set; }
        [DisplayName("Nom de famille : ")]
        public string DevName { get; set; }
        [DisplayName("Prénom : ")]
        public string DevFirstName { get; set; }
        [DisplayName("Date de naissance : ")]
        public DateTime DevBirthDate { get; set; }
        [DisplayName("Photo : ")]
        [DataType(DataType.ImageUrl)]
        public string DevPicture { get; set; }
        [DisplayName("Tarif à l'heure : ")]
        public double DevHourCost { get; set; }
        [DisplayName("Tarif au jour : ")]
        public double DevDayCost { get; set; }
        [DisplayName("Tarif au mois : ")]
        public double DevMonthCost { get; set; }
        [DisplayName("Adresse email : ")]
        public string DevMail { get; set; }
        [DisplayName("Catégorie : ")]
        public string DevCategPrincipal { get; set; }
        [DisplayName("Languages maîtrisés : ")]
        public IEnumerable<string> DevLang { get; set; }
       

    }
}
