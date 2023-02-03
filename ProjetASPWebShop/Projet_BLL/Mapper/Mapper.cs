using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLEntities = Projet_BLL.Entities;
using DALEntities = Projet_DAL.Entities;


namespace Projet_BLL.Mapper
{
    static class Mapper
    {
        public static BLLEntities.Developer ToBLL(this DALEntities.Developer entity)
        {
            if (entity is null) return null;
            return new BLLEntities.Developer()
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.DevBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMonthCost = entity.DevMonthCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal
            };
        }

        public static DALEntities.Developer ToDAL(this BLLEntities.Developer entity)
        {
            if (entity is null) return null;
            return new DALEntities.Developer()
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.DevBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMonthCost = entity.DevMonthCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal
            };
        }

        public static BLLEntities.ItLang ToBLL(this DALEntities.ItLang entity)
        {
            if (entity is null) return null;
            return new BLLEntities.ItLang()
            {
                IdIT = entity.IdIt,
                ITLabel = entity.ItLabel
            };
        }

        public static BLLEntities.DevLang ToBLL(this DALEntities.DevLang entity)
        {
            if (entity is null) return null;
            return new BLLEntities.DevLang()
            {
                IdDev = entity.idDev,
                IdIt = entity.idIt,
                Since = entity.Since
            };
        }
    }
}
