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
    public class DeveloperService : IDeveloperRepository<Developer, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";
        public IEnumerable<Developer> Get()
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            { using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SELECT [IdDev], [DevName], [DevFirstName], [DevBirthDate], [DevPicture], [DevHourCost], [DevDayCost], [DevMonthCost], [DevMail], [DevCategPrincipal] FROM [Developer]";
                    
                    connexion.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDeveloper();
                        }
                    }

                }
                                            
            }
        }

        public Developer Get(int id)
        {
            using(SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [IdDev], [DevName], [DevFirstName], [DevBirthDate], [DevPicture], [DevHourCost], [DevDayCost], [DevMonthCost], [DevMail], [DevCategPrincipal] 
                                            FROM [Developer]
                                            WHERE [IdDev] = @id";
                    command.Parameters.AddWithValue("id", id);
                    
                    connexion.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToDeveloper();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Developer entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Developer]([DevName], [DevFirstName], [DevBirthDate], [DevPicture], [DevHourCost], [DevDayCost], [DevMonthCost], [DevMail], [DevCategPrincipal])
                                            OUTPUT [inserted].[IdDev]
                                            VALUES (@DevName, @DevFirstName, @DevBirthDate, @DevPicture, @DevHourCost, @DevDayCost, @DevMonthCost, @DevMail, @DevCategPrincipal)";
                    
                    command.Parameters.AddWithValue("DevName", entity.DevName);
                    command.Parameters.AddWithValue("DevFirstName", entity.DevFirstName);
                    command.Parameters.AddWithValue("DevBirthDate", entity.DevBirthDate);
                    command.Parameters.AddWithValue("DevPicture", (object)entity.DevPicture ?? DBNull.Value);
                    command.Parameters.AddWithValue("DevHourCost", entity.DevHourCost);
                    command.Parameters.AddWithValue("DevDayCost", entity.DevDayCost);
                    command.Parameters.AddWithValue("DevMonthCost", entity.DevMonthCost);
                    command.Parameters.AddWithValue("DevMail", entity.DevMail);
                    command.Parameters.AddWithValue("DevCategPrincipal", (object)entity.DevCategPrincipal ?? DBNull.Value);
                    
                    connexion.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(Developer entity, int id)
        {
            using(SqlConnection connexion  = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Developer]
                                            SET 
                                                [DevName] = @DevName
                                                [DevFirstName] = @DevFirstName
                                                [DevBirthDate] = @DevBirthDate
                                                [DevPicture] = @DevPicture
                                                [DevHourCost] = @DevHourCost
                                                [DevDayCost] = @DevDayCost
                                                [DevMonthCost] = @DevMonthCost
                                                [DevMail] = @DevMail
                                                [DevCategPrincipal] = @DevCategPrincipal
                                            WHERE [IdDev] = @id
                                               ";
                    
                    command.Parameters.AddWithValue("DevName", entity.DevName);
                    command.Parameters.AddWithValue("DevFirstName", entity.DevFirstName);
                    command.Parameters.AddWithValue("DevBirthDate", entity.DevBirthDate);
                    command.Parameters.AddWithValue("DevPicture", (object)entity.DevPicture ?? DBNull.Value);
                    command.Parameters.AddWithValue("DevHourCost", entity.DevHourCost);
                    command.Parameters.AddWithValue("DevDayCost", entity.DevDayCost);
                    command.Parameters.AddWithValue("DevMonthCost", entity.DevMonthCost);
                    command.Parameters.AddWithValue("DevMail", entity.DevMail);
                    command.Parameters.AddWithValue("DevCategPrincipal", (object)entity.DevCategPrincipal ?? DBNull.Value);

                    command.Parameters.AddWithValue("id", id);

                    connexion.Open();
                    return (command.ExecuteNonQuery() > 0);

                }
            }
        }
    }
}
