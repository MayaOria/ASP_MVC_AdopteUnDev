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
    public class CategoriesService : ICategoriesRepository<Categories, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";

        public IEnumerable<Categories> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idCategory], [CategLabel]
                                            FROM [Categories]";

                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategory();
                        }
                    }
                }
            }
        }

            public Categories Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idCategory], [CategLabel]
                                            FROM [Categories]
                                            WHERE [idCategory] = @id";

                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToCategory();
                        }
                        return null;
                    }
                }
            }
        }

        public IEnumerable<Categories> GetByIdDev(int idDev)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT DISTINCT Categories.idCategory,                              Categories.CategLabel
                                            FROM Categories
                                            JOIN LangCateg
                                            ON Categories.idCategory = LangCateg.idCategory
                                            JOIN DevLang
                                            ON LangCateg.idIT = DevLang.idIT
                                            WHERE DevLang.idDev = @id";
                    command.Parameters.AddWithValue("id", idDev);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategory();
                        }
                    }
                }
            }
        }

        public IEnumerable<Categories> GetByIdIt(int idIt)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT Categories.idCategory, Categories.CategLabel
                                            FROM Categories
                                            JOIN LangCateg
                                            ON Categories.idCategory = LangCateg.idCategory
                                            WHERE LangCateg.idIT = @id";
                    command.Parameters.AddWithValue("id", idIt);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategory();
                        }
                    }
                }
            }
        }
    }
}

     
