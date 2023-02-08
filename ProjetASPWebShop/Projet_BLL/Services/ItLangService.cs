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
    public class ItLangService : IItLangRepository<ItLang, int>
    {

        private readonly IItLangRepository<DALEntities.ItLang, int> _repository;
        private readonly ICategoriesRepository<DALEntities.Categories, int> _categories_repository;

        public ItLangService(IItLangRepository<DALEntities.ItLang, int> repository, ICategoriesRepository<DALEntities.Categories, int> categories_repository)
        {
            _repository = repository;
            _categories_repository = categories_repository;
        }

        public IEnumerable<ItLang> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public ItLang Get(int id)
        {
            ItLang entity = _repository.Get(id).ToBLL();
            entity.Categories = _categories_repository.GetByIdIt(id).Select(e => e.ToBLL());
            return entity;

        }

        public IEnumerable<ItLang> GetByCateg(int idCateg)
        {
            return _repository.GetByCateg(idCateg).Select(e => e.ToBLL());
        }
    }
}
