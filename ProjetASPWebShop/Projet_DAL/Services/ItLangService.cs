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
    public class ItLangService : IItLangRepository<ItLang, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";

        public IEnumerable<ItLang> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SELECT [idIT], [ITLabel] FROM [ITLang]";
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToItLang();
                        }
                    }
                }
            }
        }

        public ItLang Get(int id)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idIT], [ITLabel] 
                                            FROM [ITLang] 
                                            WHERE [idIT] = @id ";
                    command.Parameters.AddWithValue("id", id);

                    connexion.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return reader.ToItLang();
                        }
                        return null;
                    }
                }
            }
        }

        public IEnumerable<ItLang> GetByCateg(int idCateg)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT ITLang.idIT, ITLang.ITLabel
                                            FROM ITLang
                                            JOIN LangCateg
                                            ON ITLang.idIT = LangCateg.idIT
                                            WHERE LangCateg.idCategory = @id";
                    command.Parameters.AddWithValue("id", idCateg);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToItLang();
                        }
                        
                    }
                }
            }
        }
    }
}
