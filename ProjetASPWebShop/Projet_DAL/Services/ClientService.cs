using Projet_Common.Repositories;
using Projet_DAL.Entities;
using Projet_DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Services
{
    public class ClientService : IClientRepository<Client, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";
        public int? CheckPassword(string login, string password)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SP_Client_CheckPassword";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("password", password);
                    connexion.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        public Client Get(int id)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [CliName], [CliFirstName], [CliMail], [CliCompany], [CliLogin], [CliPassword]
                                            FROM [Client]
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToClient();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Client entity)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SP_Client_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("name", entity.CliName);
                    command.Parameters.AddWithValue("firstname", entity.CliFirstName);
                    command.Parameters.AddWithValue("mail", entity.CliMail);
                    command.Parameters.AddWithValue("company", entity.CliCompany);
                    command.Parameters.AddWithValue("login", entity.CliLogin);
                    command.Parameters.AddWithValue("password", entity.CliPassword);

                    connexion.Open();
                    return (int)command.ExecuteScalar();

                }
            }
        }
    }
}
