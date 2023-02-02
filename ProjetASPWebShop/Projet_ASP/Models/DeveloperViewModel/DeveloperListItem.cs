using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.DeveloperViewModel
{
    public class DeveloperListItem
    {
        [ScaffoldColumn(false)]
        public int IdDev { get; set; }
        [DisplayName("Photo : ")]
        [DataType(DataType.ImageUrl)]
        public string DevPicture { get; set; }
        [DisplayName("Prénom : ")]
        public string DevFirstName { get; set; }
        [DisplayName("Nom de famille : ")]
        public string DevName { get; set; }
        [DisplayName("Catégorie : ")]
        public string DevCategPrincipal { get; set; }
        [DisplayName("Tarif à l'heure : ")]
        public double DevHourCost { get; set; }
    }
}
