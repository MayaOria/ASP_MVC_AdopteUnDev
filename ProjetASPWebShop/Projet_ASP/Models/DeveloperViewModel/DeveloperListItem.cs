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
        
        [DataType(DataType.ImageUrl)]
        public string DevPicture { get; set; }
        
        public string DevFirstName { get; set; }
        
        public string DevName { get; set; }
        
        public string DevCategPrincipal { get; set; }
        
        public double DevHourCost { get; set; }
    }
}
