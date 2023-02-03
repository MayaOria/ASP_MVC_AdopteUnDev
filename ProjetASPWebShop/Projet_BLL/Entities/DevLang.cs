using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BLL.Entities
{
    public class DevLang : IDevLang
    {
        public int IdDev { get; set; }
        public int IdIt { get; set; }
        public DateTime? Since {get; set;}
        public ItLang Lang { get; set; }

    }
}
