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
        }

        public static ItLang ToItLang(this IDataRecord record)
        {
            if (record is null) return null;
            return new ItLang()
            {
                IdIt = (int)record[nameof(ItLang.IdIt)],
                ItLabel = (string)record[nameof(ItLang.ItLabel)]
            };
        }

        public static DevLang ToDevLang(this IDataRecord record)
        {
            if (record is null) return null;
            return new DevLang()
            {
                idDev = (int)record[nameof(DevLang.idDev)],
                idIt = (int)record[nameof(DevLang.idIt)],
                Since = (record[nameof(DevLang.Since)] is DBNull) ? null :(DateTime)record[nameof(DevLang.Since)]
            };
        }

        public static Categories ToCategory(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categories()
            {
                IdCategory = (int)record[nameof(Categories.IdCategory)],
                CategLabel = (string)record[nameof(Categories.CategLabel)]
            };
        }

        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                idClient = (int)record[nameof(Client.idClient)],
                CliName = (string)record[nameof(Client.CliName)],
                CliFirstName = (string)record[nameof(Client.CliFirstName)],
                CliMail = (string)record[nameof(Client.CliMail)],
                CliCompany = (string)record[nameof(Client.CliCompany)],
                CliLogin = (string)record[nameof(Client.CliLogin)],
                CliPassword = "********"
            };
        }

        public static ClientEndorseDev ToClientEndorseDev(this IDataRecord record)
        {
            if (record is null) return null;
            return new ClientEndorseDev()
            {
                idClient = (int)record[nameof(ClientEndorseDev.idClient)],
                idDev = (int)record[nameof(ClientEndorseDev.idDev)],
                BeginDate = (DateTime)record[nameof(ClientEndorseDev.BeginDate)],
                EndDate = (DateTime)record[nameof(ClientEndorseDev.EndDate)],
                EndorseNumber = (int)record[nameof(ClientEndorseDev.EndorseNumber)],
            }; 
        }
    }
}
