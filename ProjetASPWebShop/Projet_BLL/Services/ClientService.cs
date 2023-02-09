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
    public class ClientService : IClientRepository<Client, int>
    {
        private readonly IClientRepository<DALEntities.Client, int> _repository;

        public ClientService(IClientRepository<DALEntities.Client, int> repository)
        {
            _repository = repository;
        }

        public int? CheckPassword(string login, string password)
        {
            return _repository.CheckPassword(login, password);
        }

        public Client Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Client entity)
        {
            return _repository.Insert(entity.ToDAL());
        }
    }
}
