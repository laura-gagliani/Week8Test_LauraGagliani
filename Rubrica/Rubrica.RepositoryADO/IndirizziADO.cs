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
    public class IndirizziADO : IRepositoryIndirizzi
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rubrica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool Add(Indirizzo item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Indirizzo values (@tipologia, @via, @citta, @cap, @provincia, @nazione, @idcontatto)";
                command.Parameters.AddWithValue("@tipologia", item.Tipologia);
                command.Parameters.AddWithValue("@via", item.Via);
                command.Parameters.AddWithValue("@citta", item.Citta);
                command.Parameters.AddWithValue("@cap", item.CAP);
                command.Parameters.AddWithValue("@provincia", item.Provincia);
                command.Parameters.AddWithValue("@nazione", item.Nazione);
                command.Parameters.AddWithValue("@idcontatto", item.IdContatto);

                int rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                    return true;
                else
                    return false;          


            }
        }

        public List<Indirizzo> GetByIdContatto(int idContatto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Indirizzo where IdContattoIndirizzo=@id";
                command.Parameters.AddWithValue("@id", idContatto);

                SqlDataReader reader = command.ExecuteReader();

                List<Indirizzo> indirizzi = new List<Indirizzo>();
                while (reader.Read())
                {
                    Indirizzo i = new Indirizzo();
                    i.IdIndirizzo = (int)reader["IdIndirizzo"];

                    indirizzi.Add(i);
                }
                connection.Close();

                return indirizzi;
            }
        }
    }
}
