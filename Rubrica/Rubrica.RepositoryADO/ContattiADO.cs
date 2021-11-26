using Rubrica.Core.Entities;
using Rubrica.Core.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.RepositoryADO
{
    public class ContattiADO : IRepositoryContatti
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rubrica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
 
        public bool Add(Contatto item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Contatto values (@nome, @cognome)";
                command.Parameters.AddWithValue("@nome", item.Nome);
                command.Parameters.AddWithValue("@cognome", item.Cognome);

                int rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                    return true;
                else
                    return false;


            }
        }

        public bool Delete(Contatto c)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from Contatto where IdContatto=@id";
                command.Parameters.AddWithValue("@id", c.IdContatto);

                int rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                    return true;
                else
                    return false;


            }
        }

        public List<Contatto> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Contatto";

                SqlDataReader reader = command.ExecuteReader();

                List<Contatto> contatti = new List<Contatto>();
                while (reader.Read())
                {
                    Contatto c = new Contatto();
                    c.IdContatto = (int)reader["IdContatto"];
                    c.Nome = (string)reader["Nome"];
                    c.Cognome = (string)reader["Cognome"];

                    contatti.Add(c);
                }
                connection.Close();

                return contatti;
            }
        }

        public Contatto GetById(int idContatto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Contatto where IdContatto=@id";
                command.Parameters.AddWithValue("@id", idContatto);

                SqlDataReader reader = command.ExecuteReader();
                Contatto c = new Contatto();

                while (reader.Read())
                {
                    c.IdContatto = (int)reader["IdContatto"];
                    c.Nome = (string)reader["Nome"];
                    c.Cognome = (string)reader["Cognome"];

                }
                connection.Close();

                return c;
            }
        }
    }
}
