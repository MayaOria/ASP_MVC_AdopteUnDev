using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Entities
{
    public class Client : IClient
    { 
        //INT
        public int idClient { get; set; }
        //NVARCHAR(50)
        public string CliName { get; set; }
        //NVARCHAR(50)
        public string CliFirstName { get; set; }
        //NVARCHAR(250)
        public string CliMail { get; set; }
        //NVARCHAR(50)
        public string CliCompany { get; set; }
        //NVARCHAR(50)
        public string CliLogin { get; set; }
        //NVARCHAR(32)
        public string CliPassword { get; set; }


    }
}
