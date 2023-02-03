using Projet_BLL.Entities;
using Projet_BLL.Mapper;
using Projet_Common.Entities;
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
    public class DeveloperService : IDeveloperRepository<Developer, int>
    {
        private readonly IDeveloperRepository<DALEntities.Developer, int> _repository;
        private readonly IDevLangRepository<DevLang, int> _DevLang_repository;

        public DeveloperService(IDeveloperRepository<DALEntities.Developer, int> repository, IDevLangRepository<DevLang, int> devLang_repository)
        {
            _repository = repository;
            _DevLang_repository = devLang_repository;
        }

        public IEnumerable<Developer> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Developer Get(int id)
        {
            Developer entity = _repository.Get(id).ToBLL();
            entity.Devlang = _DevLang_repository.GetByDev(id);
            return entity;
        }

        public int Insert(Developer entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(Developer entity, int id)
        {
            return _repository.Update(entity.ToDAL(), id);
        }
    }
}
