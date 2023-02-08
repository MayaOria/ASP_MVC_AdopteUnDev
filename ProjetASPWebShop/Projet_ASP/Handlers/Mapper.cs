using Projet_ASP.Models.CategoriesViewModels;
using Projet_ASP.Models.DeveloperViewModel;
using Projet_ASP.Models.HomeViewModel;
using Projet_ASP.Models.ItLangViewModels;
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
                DevCategPrincipal = entity.DevCategPrincipal,
                DevLang = entity.Devlang.Select(e => e.Lang.ITLabel)
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

        public static ItLangListItem ToListItem(this Projet_BLL.Entities.ItLang entity)
        {
            if (entity is null) return null;
            return new ItLangListItem()
            {
                IdIT = entity.IdIT,
                ItLabel = entity.ITLabel
            };
        }

        public static ItLangDetails ToDetails(this Projet_BLL.Entities.ItLang entity)
        {
            if (entity is null) return null;
            return new ItLangDetails()
            {
                IdIT = entity.IdIT,
                IdLabel = entity.ITLabel,
                categories = entity.Categories
                

            };
        }

        public static CategoriesListItem ToListItem(this Categories entity)
        {
            if (entity is null) return null;
            return new CategoriesListItem()
            {
                IdCategory = entity.IdCategory,
                CategLabel = entity.CategLabel
            };
        }

        public static CategoriesDetails ToDetails(this Categories entity)
        {
            if (entity is null) return null;
            return new CategoriesDetails()
            {
                IdCategory = entity.IdCategory,
                IdLabel = entity.CategLabel,
                itLangs = entity.ItLangues
            };
        }

        
    }
}
