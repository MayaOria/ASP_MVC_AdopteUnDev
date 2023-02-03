using Projet_BLL.Entities;
using Projet_BLL.Mapper;
using Projet_Common.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BLL.Services
{
    public class DevLangService : IDevLangRepository<DevLang, int>
    {
        private readonly IDevLangRepository<Projet_DAL.Entities.DevLang, int> _repository;
        private readonly IItLangRepository<Projet_DAL.Entities.ItLang, int> _ItLang_repository;

        public DevLangService(IDevLangRepository<Projet_DAL.Entities.DevLang, int> repository, IItLangRepository<Projet_DAL.Entities.ItLang, int> itLang_repository)
        {
            _repository = repository;
            _ItLang_repository = itLang_repository;
        }

        public IEnumerable<DevLang> GetByDev(int idDev)
        {
            IEnumerable<DevLang> Langs = _repository.GetByDev(idDev).Select(e=> e.ToBLL());
            Langs = Langs.Select(e => {
                e.Lang = _ItLang_repository.Get(e.IdIt).ToBLL();
                return e; });
            return Langs;
        }
    }
}
