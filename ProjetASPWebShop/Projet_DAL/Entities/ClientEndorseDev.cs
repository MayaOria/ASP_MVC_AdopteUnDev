﻿using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Entities
{
    public class ClientEndorseDev : IClientEndorseDev
    {
        //INT
        public int idClient { get; set; }
        //INT
        public int idDev { get; set; }
        //DATETIME
        public DateTime BeginDate { get; set; }
        //DATETIME
        public DateTime EndDate { get; set; }
        //UniqueIdentifier
        public long EndorseNumber { get; set; }
    }
}
