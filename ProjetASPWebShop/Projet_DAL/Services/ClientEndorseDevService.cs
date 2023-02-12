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
    internal class ClientEndorseDevService : IClientEndorseDevRepository<ClientEndorseDev, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";

        public IEnumerable<ClientEndorseDev> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [idDev], [BeginDate], [EndDate], [EndorseNumber]
                                        FROM [ClientEndorseDev]";
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClientEndorseDev();
                        }
                    }
                }
            }
            
        }

        public ClientEndorseDev Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [idDev], [BeginDate], [EndDate], [EndorseNumber]
                                        FROM [ClientEndorseDev]
                                        WHERE [EndorseNumber] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToClientEndorseDev();
                        }
                        return null;
                    }
                }
            }
        }

        public IEnumerable<ClientEndorseDev> GetByIdClient(int id)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [idDev], [BeginDate], [EndDate], [EndorseNumber]
                                        FROM [ClientEndorseDev]
                                        WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClientEndorseDev();
                        }
                        
                    }
                }

            }
        }

        public IEnumerable<ClientEndorseDev> GetByIdDev(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [idDev], [BeginDate], [EndDate], [EndorseNumber]
                                        FROM [ClientEndorseDev]
                                        WHERE [idDev] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClientEndorseDev();
                        }
                    }
                }
            }
        }

        public int Insert(ClientEndorseDev entity)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [ClientEndorseDev]([idClient], [idDev], [BeginDate], [EndDate])
                      OUTPUT [inserted].[EndorseNumber]
                      VALUES (@idClient, @idDev, @BeginDate, @EndDate)";

                    command.Parameters.AddWithValue("idClient", entity.idClient);
                    command.Parameters.AddWithValue("idDev", entity.idDev);
                    command.Parameters.AddWithValue("BeginDate", entity.BeginDate);
                    command.Parameters.AddWithValue("EndDate", entity.EndDate);

                    connexion.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
