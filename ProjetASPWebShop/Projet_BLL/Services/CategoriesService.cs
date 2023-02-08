using Projet_BLL.Entities;
using Projet_BLL.Mapper;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEntities = Projet_DAL.Entities;
using DALServices = Projet_DAL.Services;

namespace Projet_BLL.Services
{
    public class CategoriesService : ICategoriesRepository<Categories, int>
    {
        private readonly ICategoriesRepository<DALEntities.Categories, int> _repository;

        private readonly IItLangRepository<DALEntities.ItLang, int> _ITLang_repository;

        public CategoriesService(ICategoriesRepository<DALEntities.Categories, int> repository, IItLangRepository<DALEntities.ItLang, int> iTLang_repository)
        {
            _repository = repository;
            _ITLang_repository = iTLang_repository;
        }

        public IEnumerable<Categories> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Categories Get(int id)
        {
            Categories entity = _repository.Get(id).ToBLL();
            entity.ItLangues = _ITLang_repository.GetByCateg(id).Select(e => e.ToBLL());
            return entity;
        }

        public IEnumerable<Categories> GetByIdDev(int idDev)
        {
            return _repository.GetByIdDev(idDev).Select(e => e.ToBLL());
        }

        public IEnumerable<Categories> GetByIdIt(int idIt)
        {
            return _repository.GetByIdIt(idIt).Select(e => e.ToBLL());
        }
    }
}
