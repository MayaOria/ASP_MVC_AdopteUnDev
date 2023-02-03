using Projet_Common.Repositories;
using Projet_DAL.Entities;
using Projet_DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Services
{
    public class DevLangService : IDevLangRepository<DevLang, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";

        public IEnumerable<DevLang> GetByDev(int idDev)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idIT], [idDev], [Since]
                                            FROM [DevLang] 
                                            WHERE [idDev] = @idDev";
                    command.Parameters.AddWithValue("idDev", idDev);
                    connexion.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            yield return reader.ToDevLang();
                        }
                            
                    }
                }
            }
        }
    }
}
