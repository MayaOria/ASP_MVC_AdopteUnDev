using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Handlers
{
    public class CurrentUser
    {
        public int IdUser {get; set;}
        public string Login { get; set; }
        public DateTime LastConnection { get; set; }
    }
}
