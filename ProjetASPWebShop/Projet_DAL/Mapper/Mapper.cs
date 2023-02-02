using Projet_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Mapper
{
    static class Mapper
    {
        public static Developer ToDeveloper(this IDataRecord record)
        {
            if (record is null) return null;
            return new Developer()
            {
                IdDev = (int)record[nameof(Developer.IdDev)],
                DevName = (string)record[nameof(Developer.DevName)],
                DevFirstName = (string)record[nameof(Developer.DevFirstName)],
                DevBirthDate = (DateTime)record[nameof(Developer.DevBirthDate)],
                DevPicture = (record[nameof(Developer.DevPicture)] is DBNull) ? null : (string)record[nameof(Developer.DevPicture)],
                DevHourCost = (double)record[nameof(Developer.DevHourCost)],
                DevDayCost = (double)record[nameof(Developer.DevDayCost)],
                DevMonthCost = (double)record[nameof(Developer.DevMonthCost)],
                DevMail = (string)record[nameof(Developer.DevMail)],
                DevCategPrincipal = (record[nameof(Developer.DevCategPrincipal)] is DBNull) ? null : (string)record[nameof(Developer.DevCategPrincipal)]
            };

            //adresse = (record[nameof(Client.adresse)] is DBNull) ? null : (string)record[nameof(Client.adresse)]
        }
    }
}
