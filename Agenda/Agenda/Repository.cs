using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

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

        public List<Contacto> GetAllContacts()
        {
            connection.Open();

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
                connection.Close();
            }

            return lista;
        }

        public void AniadirContacto(int id, string nombre, string FechaNacimiento, string telefono, string? Observacion)
        {
            connection.Open();
            string query = $"INSERT INTO Contactos VALUES ('{nombre}','{FechaNacimiento}','{telefono}','{Observacion}')";

            try
            {
                if (connection != null)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }finally
            {
                connection.Close();
            }
        }
    }
}
