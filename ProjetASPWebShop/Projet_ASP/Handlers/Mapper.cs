using Projet_ASP.Models.DeveloperViewModel;
using Projet_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Handlers
{
    public static class Mapper
    {
        public static DeveloperListItem ToListItem(this Projet_BLL.Entities.Developer entity)
        {
            if (entity is null) return null;
            return new DeveloperListItem()
            {
                IdDev = entity.IdDev,
                DevPicture = entity.DevPicture,
                DevFirstName = entity.DevFirstName,
                DevName = entity.DevName,
                DevHourCost = entity.DevHourCost,
                DevCategPrincipal = entity.DevCategPrincipal
            };
        }

        public static DeveloperDetails ToDetails(this Projet_BLL.Entities.Developer entity)
        {
            if (entity is null) return null;
            return new DeveloperDetails()
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

        public static Developer ToBLL(this DeveloperCreateForm entity)
        {
            if (entity is null) return null;
            return new Developer()
            {
               
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
    }
}
