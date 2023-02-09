using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.ClientViewModel
{
    public class ClientDetails
    {
       
        [DisplayName("Nom de famille : ")]
        public string CliName { get; set; }
        
        [DisplayName("Prénom : ")]
        public string CliFirstName { get; set; }
        
        [EmailAddress]
        [DisplayName("Adresse e-mail : ")]
        public string CliMail { get; set; }
        
        [DisplayName("Nom de l'entreprise : ")]
        public string CliCompany { get; set; }
        
    }
}
