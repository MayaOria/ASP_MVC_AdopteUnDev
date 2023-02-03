using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BLL.Entities
{
    public class ItLang: IItLang
    {
        public int IdIT { get; set; }
        public string ITLabel { get; set; }
    }
}
