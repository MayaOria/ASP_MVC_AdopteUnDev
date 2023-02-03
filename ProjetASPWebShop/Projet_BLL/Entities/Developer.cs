﻿using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BLL.Entities
{
   
        public class Developer : IDeveloper
        {
            
            public int IdDev { get; set; }
            
            public string DevName { get; set; }
            
            public string DevFirstName { get; set; }
            
            public DateTime DevBirthDate { get; set; }
            
            public string DevPicture { get; set; }
            
            public double DevHourCost { get; set; }
            
            public double DevDayCost { get; set; }
            
            public double DevMonthCost { get; set; }
            
            public string DevMail { get; set; }
            
            public string DevCategPrincipal { get; set; }
            
            public IEnumerable<DevLang> Devlang { get; set; }
        
        }
    
}
