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

        public ItLangService(IItLangRepository<DALEntities.ItLang, int> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ItLang> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public ItLang Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
    }
}
