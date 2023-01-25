using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Entities
{
    public class Developer
    {
        //INT
        public int IdDev { get; set; }
        //NVARCHAR(50)
        public string DevName { get; set; }
        //NVARCHAR(50)
        public string DevFirstName { get; set; }
        //DATETIME  
        public DateTime DevBirthDate { get; set; }
        //NVARCHAR(50) | NULLABLE
        public string DevPicture { get; set; }
        //FLOAT
        public double DevHourCost { get; set; }
        //FLOAT
        public double DevDayCost { get; set; }
        //FLOAT
        public double DevMonthCost { get; set; }
        //NVARCHAR(250)
        public string DevMail { get; set; }
        //NVARCHAR(250)| NULLABLE
        public string DevCategPrincipal { get; set; }
    }
}
