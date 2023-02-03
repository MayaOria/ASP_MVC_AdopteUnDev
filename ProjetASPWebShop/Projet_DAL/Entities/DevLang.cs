using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Entities
{
    public class DevLang: IDevLang
    {
        //INT
        public int idDev { get; set; }
        //INT
        public int idIt { get; set; }

        //DATETIME NULLABLE
        public DateTime? Since { get; set; }
    }
}
