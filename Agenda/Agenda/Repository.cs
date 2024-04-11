using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agenda
{
    internal class Repository
    {
        private readonly SqlConnection connection;
        private const string NombreBD = "Agenda";

        public Repository()
        {
            connection = ContextDB.CreateConnection(NombreBD);
        }

        private void OpenConnection() => connection.Open();
        private void CloseConnection() => connection.Close();  

        public List<Contacto> GetAllContacts()
        {
            OpenConnection();

            string query = "SELECT * FROM Contactos";
            List<Contacto> lista = new List<Contacto>();

            try
            {
                if (connection != null)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        lista.Add(new Contacto(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetString(4)
                            ));
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }finally
            {
                CloseConnection();
            }

            return lista;
        }
    }
}
